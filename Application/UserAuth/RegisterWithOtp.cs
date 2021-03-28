using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using Application.Interfaces;
using Domain.DTOs;
using Domain.Models.User;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Application.UserAuth
{
    public class RegisterWithOtp
    {
        public class Command : IRequest<UserDTO>
        {
            public string PhoneNumber { get; set; }
            public string Otp { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.PhoneNumber).NotEmpty();
                RuleFor(x => x.Otp).NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Command,UserDTO>
        {
            private readonly YourLawyerContext _context;
            private readonly IJwtGenerator _jwtGenerator;
            private readonly UserManager<AppUser> _userManager;
            public Handler(YourLawyerContext context, UserManager<AppUser> userManager, IJwtGenerator jwtGenerator)
            {
                _userManager = userManager;
                _jwtGenerator = jwtGenerator;
                _context = context;

            }

            public async Task<UserDTO> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.PhoneNumber == request.PhoneNumber);

                if (user == null) throw new RestException(HttpStatusCode.NotFound, new { error = "No user found with this number" });

            
                    if(user.Otp == request.Otp)
                    {
                        user.PhoneNumberConfirmed = true;

                        user.Otp = null;
                             
                        await _userManager.UpdateAsync(user);
                        return new UserDTO
                        {
                            Token = _jwtGenerator.CreateToken(user),
                            FullName = user.FirstName+" "+user.LastName ,
                            PhoneNumber= user.PhoneNumber                         
                        };
                    }
              
                  throw new RestException(HttpStatusCode.Unauthorized, new { error = "bhung bhang credentials dile dhukte parben na" });
            }
        }
    }
}