using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using Application.Interfaces;
using AutoMapper;
using Domain.DTOs;
using Domain.Models.User;
using FluentValidation;
using MediatR;
using Microsoft.AspNetCore.Identity;

namespace Application.UserAuth
{
    public class Login
    {
        public class Query : IRequest<UserDTO>
        {
            public string Email { get; set; }
            public string Password { get; set; }
        }
        public class QueryValidator : AbstractValidator<Query>
        {
            public QueryValidator()
            {
                RuleFor(x => x.Email).NotEmpty();
                RuleFor(x => x.Password).NotEmpty();
            }
        }

        public class Handler : IRequestHandler<Query, UserDTO>
        {
            private readonly SignInManager<AppUser> _signInManager;
            private readonly UserManager<AppUser> _userManager;
            private readonly IJwtGenerator _jwtGenerator;
            public Handler(SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IJwtGenerator jwtGenerator)
            {
                _jwtGenerator = jwtGenerator;
                _userManager = userManager;
                _signInManager = signInManager;
            }

            public async Task<UserDTO> Handle(Query request, CancellationToken cancellationToken)
            {
                var user = await _userManager.FindByEmailAsync(request.Email);
                if (user == null)
                    throw new RestException(HttpStatusCode.Unauthorized, new { error = "bhung bhang credentials dile dhukte parben na" });
                var result = await _signInManager.CheckPasswordSignInAsync(user, request.Password, false);
                if (result.Succeeded)
                {
                    return new UserDTO
                    {
                        UserName = user.UserName,
                        Email = user.Email,
                        Token = _jwtGenerator.CreateToken(user)
                    };
                }
                throw new RestException(HttpStatusCode.Unauthorized, new { error = "bhung bhang credentials dile dhukte parben na" });
            }
        }
    }
}