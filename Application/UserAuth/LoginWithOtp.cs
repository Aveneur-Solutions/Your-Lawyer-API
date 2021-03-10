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
using Microsoft.Extensions.Configuration;
using Persistence.DataContext;

namespace Application.UserAuth
{
    public class LoginWithOtp
    {
        public class Query : IRequest<UserDTO>
        {
            public string PhoneNumber { get; set; }
            public string Otp { get; set; }
        }
        public class QueryValidator : AbstractValidator<Query>
        {
            public QueryValidator()
            {
                RuleFor(x => x.PhoneNumber).NotEmpty();
                RuleFor(x => x.Otp).NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Query, UserDTO>
        {
            private readonly SignInManager<AppUser> _signInManager;
            private readonly UserManager<AppUser> _userManager;
            private readonly IJwtGenerator _jwtGenerator;
            private readonly IConfiguration _configuration;
            private readonly YourLawyerContext _context;
            public Handler(YourLawyerContext context, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IJwtGenerator jwtGenerator, IConfiguration configuration)
            {
                _context = context;
                _configuration = configuration;
                _jwtGenerator = jwtGenerator;
                _userManager = userManager;
                _signInManager = signInManager;
            }

            public async Task<UserDTO> Handle(Query request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.FirstOrDefaultAsync( x=> x.PhoneNumber == request.PhoneNumber);
                if (user == null)
                    throw new RestException(HttpStatusCode.Unauthorized, new { error = "bhung bhang credentials dile dhukte parben na" });


                if(!String.IsNullOrEmpty(user.Otp) && user.Otp == request.Otp)
                {
                    user.Otp = null;
                    await _userManager.UpdateAsync(user);
                    return new UserDTO
                    {
                        UserName = user.UserName,
                        Email = user.Email,
                        Token = _jwtGenerator.CreateToken(user)
                    };
                }
                else throw new RestException(HttpStatusCode.Unauthorized, new { error = "Faizlami Koren mia" });
                
                throw new RestException(HttpStatusCode.Unauthorized, new { error = "bhung bhang credentials dile dhukte parben na" });
            }
        }
    }
}