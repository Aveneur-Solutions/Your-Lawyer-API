using System.Threading;
using System.Threading.Tasks;
using Application.Interfaces;
using Domain.DTOs;
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
            private readonly UserManager<AppUser> _userManager;
            public Handler(IUserAccessor userAccessor, IJwtGenerator jwtGenerator, UserManager<AppUser> userManager)
            {
                _userManager = userManager;
                _jwtGenerator = jwtGenerator;
                _userAccessor = userAccessor;
            }
            public async Task<UserDTO> Handle(Query request, CancellationToken cancellationToken)
            {
                var currentUser = await _userManager.FindByNameAsync(_userAccessor.GetCurrentUsername());

                var user = new UserDTO
                {
                    UserName = currentUser.UserName,
                    Email = currentUser.Email,
                    Token = _jwtGenerator.CreateToken(currentUser)
                };

                return user;
            }
        }
    }
}