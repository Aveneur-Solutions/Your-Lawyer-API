using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using Application.Helper;
using Application.Interfaces;
using Application.SMSService;
using AutoMapper;
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
    public class Login
    {
        public class Command : IRequest
        {
            public string PhoneNumber { get; set; }
            public string Password { get; set; }
        }
        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.PhoneNumber).NotEmpty();
                RuleFor(x => x.Password).NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Command>
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

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.FirstOrDefaultAsync(x => x.PhoneNumber == request.PhoneNumber);
                if (user == null)
                    throw new RestException(HttpStatusCode.Unauthorized, new { error = "bhung bhang credentials dile dhukte parben na" });
                var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);


                if (result.Succeeded)
                {
                  
// //                     string sixDigitNumber = RandomDigitGenerator.SixDigitNumber() ;
// //                     string OTPMessage = sixDigitNumber + " xYH2mfwStJ8"; // implemented in helper folder 
// //                     await AuthMessageSender.SendSmsAsync(request.PhoneNumber, OTPMessage, _configuration);
//                     user.Otp = sixDigitNumber;
                    string sixDigitNumber = "000000";
                    user.OTP = sixDigitNumber;
                    await _userManager.UpdateAsync(user);
                    // return new UserDTO
                    // {
                    //     UserName = user.UserName,
                    //     Email = user.Email,
                    //     Token = _jwtGenerator.CreateToken(user)
                    // };
                     return Unit.Value;
                }
                throw new RestException(HttpStatusCode.Unauthorized, new { error = "bhung bhang credentials dile dhukte parben na" });
            }
        }
    }
}
