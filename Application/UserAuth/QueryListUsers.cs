using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using AutoMapper;
using Domain.DTOs;
using Domain.Models.Messages;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Application.UserAuth
{
    public class QueryListUsers
    {
        public class Query : IRequest<List<UserDTO>> { }

        public class Handler : IRequestHandler<Query, List<UserDTO>>
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
            public async Task<List<UserDTO>> Handle(Query request, CancellationToken cancellationToken)
            {
                var users = await _context.Users
                    .Include(x => x.SentQueryTexts)
                    // .ThenInclude(x => x.Sender)
                    .ToListAsync();


                var queryUsers = new List<UserDTO>();


                foreach (var user in users)
                {
                    if (user.SentQueryTexts.Count != 0 && user.FirstName != "LegalX")
                    {
                        var u = new UserDTO
                        {
                            FullName = user.FirstName + " " + user.LastName,
                            PhoneNumber = user.PhoneNumber,
                            SentQueryTexts = _mapper.Map<ICollection<QueryText>, List<QueryTextDTO>>(user.SentQueryTexts),
                            ReceivedQueryTexts = _mapper.Map<ICollection<QueryText>, List<QueryTextDTO>>(user.ReceivedQueryTexts),
                            SentQueryFiles = _mapper.Map<ICollection<QueryFile>, List<QueryFileDTO>>(user.SentQueryFiles),
                            ReceivedQueryFiles = _mapper.Map<ICollection<QueryFile>, List<QueryFileDTO>>(user.ReceivedQueryFiles)
                        };
                        queryUsers.Add(u);
                    }
                }
                return queryUsers;
            }
        }
    }
}