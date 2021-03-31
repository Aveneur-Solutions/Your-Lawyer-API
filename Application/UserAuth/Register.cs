using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using Application.Helper;
using Application.Interfaces;
using Application.SMSService;
using Domain.Models.User;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Persistence.DataContext;

namespace Application.UserAuth
{
    public class Register
    {

        public class Command : IRequest
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string Password { get; set; }
        }
        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.FirstName).NotEmpty();
                RuleFor(x => x.LastName).NotEmpty();
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
                    {
                        user = new AppUser
                        {
                            FirstName = request.FirstName,
                            LastName = request.LastName,
                            PhoneNumber = request.PhoneNumber,
                            UserName = request.FirstName
                        };
                        string sixDigitNumber = RandomDigitGenerator.SixDigitNumber() ;
                        string OTPMessage = sixDigitNumber + " xYH2mfwStJ8";
                        user.Otp = sixDigitNumber;
                        await AuthMessageSender.SendSmsAsync(request.PhoneNumber, OTPMessage, _configuration);
                        await _userManager.CreateAsync(user, request.Password);
                        return Unit.Value;
                    }
                    else throw new RestException(HttpStatusCode.Conflict, new { error = "a user already exists with this number" });
             

                throw new RestException(HttpStatusCode.Unauthorized, new { error = "Kichu ekta to jhamela korsen e naile ei line execute howar kotha na" });


            }
        }
    }
}
