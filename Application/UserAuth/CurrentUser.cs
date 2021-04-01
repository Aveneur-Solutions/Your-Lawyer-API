using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using AutoMapper;
using Domain.DTOs;
using Domain.Models.Messages;
using Domain.Models.User;
using MediatR;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Application.UserAuth
{
    public class CurrentUser
    {
        public class Query : IRequest<UserDTO> { }

        public class Handler : IRequestHandler<Query, UserDTO>
        {
            private readonly IUserAccessor _userAccessor;
            private readonly IJwtGenerator _jwtGenerator;
            private readonly IMapper _mapper;
            private readonly YourLawyerContext _context;
            public Handler(YourLawyerContext context, IUserAccessor userAccessor, IJwtGenerator jwtGenerator, IMapper mapper)
            {
                _context = context;
                _mapper = mapper;
                _jwtGenerator = jwtGenerator;
                _userAccessor = userAccessor;
            }
            public async Task<UserDTO> Handle(Query request, CancellationToken cancellationToken)
            {
                var currentUser = await _context.Users
                    .Include(x => x.SentQueryTexts)
                        .ThenInclude(x => x.Receiver)
                    .Include(x => x.ReceivedQueryTexts)
                     .ThenInclude(x => x.Sender)
                    .Include(x => x.SentQueryFiles)
                    // .ThenInclude(x => x.Receiver)
                    .Include(x => x.ReceivedQueryFiles)
                    // .ThenInclude(x => x.Sender)
                    .FirstOrDefaultAsync(x => x.PhoneNumber == _userAccessor.GetCurrentUserPhoneNo());

                var user = new UserDTO
                {
                    FullName = currentUser.FirstName + " " + currentUser.LastName,
                    PhoneNumber = currentUser.PhoneNumber,
                    Token = _jwtGenerator.CreateToken(currentUser),
                    SentQueryTexts = _mapper.Map<ICollection<QueryText>, List<QueryTextDTO>>(currentUser.SentQueryTexts),
                    ReceivedQueryTexts = _mapper.Map<ICollection<QueryText>, List<QueryTextDTO>>(currentUser.ReceivedQueryTexts),
                    SentQueryFiles = _mapper.Map<ICollection<QueryFile>, List<QueryFileDTO>>(currentUser.SentQueryFiles),
                    ReceivedQueryFiles = _mapper.Map<ICollection<QueryFile>, List<QueryFileDTO>>(currentUser.ReceivedQueryFiles)
                };

                return user;
            }
        }
    }
}