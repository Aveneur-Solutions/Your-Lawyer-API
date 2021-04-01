using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using Application.Interfaces;
using AutoMapper;
using Domain.DTOs;
using Domain.Models.Messages;
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
            private readonly IMapper _mapper;
            public Handler(YourLawyerContext context, SignInManager<AppUser> signInManager, UserManager<AppUser> userManager, IJwtGenerator jwtGenerator, IConfiguration configuration, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
                _configuration = configuration;
                _jwtGenerator = jwtGenerator;
                _userManager = userManager;
                _signInManager = signInManager;
            }

            public async Task<UserDTO> Handle(Query request, CancellationToken cancellationToken)
            {
                var user = await _context.Users.
                Include(x => x.SentQueryTexts).
                 ThenInclude(x => x.Receiver).
                Include(x => x.ReceivedQueryTexts).
                 ThenInclude(x => x.Sender).
                Include(x => x.SentQueryFiles).
                Include(x => x.ReceivedQueryFiles).
                FirstOrDefaultAsync(x => x.PhoneNumber == request.PhoneNumber);
                if (user == null)
                    throw new RestException(HttpStatusCode.Unauthorized, new { error = "bhung bhang credentials dile dhukte parben na" });


                if (!String.IsNullOrEmpty(user.Otp) && user.Otp == request.Otp)
                {
                    user.Otp = null;
                    await _userManager.UpdateAsync(user);
                    return new UserDTO
                    {
                        FullName = user.FirstName + " " + user.LastName,
                        PhoneNumber = user.PhoneNumber,
                        Token = _jwtGenerator.CreateToken(user),
                        SentQueryTexts = _mapper.Map<ICollection<QueryText>, List<QueryTextDTO>>(user.SentQueryTexts),
                        ReceivedQueryTexts = _mapper.Map<ICollection<QueryText>, List<QueryTextDTO>>(user.ReceivedQueryTexts),
                        SentQueryFiles = _mapper.Map<ICollection<QueryFile>, List<QueryFileDTO>>(user.SentQueryFiles),
                        ReceivedQueryFiles = _mapper.Map<ICollection<QueryFile>, List<QueryFileDTO>>(user.ReceivedQueryFiles)
                    };
                }
                else throw new RestException(HttpStatusCode.Unauthorized, new { error = "Faizlami Koren mia" });

                throw new RestException(HttpStatusCode.Unauthorized, new { error = "bhung bhang credentials dile dhukte parben na" });
            }
        }
    }
}