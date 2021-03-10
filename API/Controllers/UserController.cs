using System.Threading.Tasks;
using Application.UserAuth;
using Domain.DTOs;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserController : BaseController
    {
        // [Route("user/login")]
        [HttpPost("login")]
        [AllowAnonymous]
        public async Task<ActionResult<Unit>> Login(Login.Command command)
        {
            return await Mediator.Send(command);
        }
        [HttpPost("loginWithOtp")]
        [AllowAnonymous]
        public async Task<ActionResult<UserDTO>> LoginWithOtp(LoginWithOtp.Query query)
        {
            return await Mediator.Send(query);
        }
        [HttpPost("register")]
        [AllowAnonymous]
        public async Task<ActionResult<Unit>> Register(Register.Command command)
        {
            return await Mediator.Send(command);
        }
        [HttpPost("registerWithOtp")]
        [AllowAnonymous]
        public async Task<ActionResult<UserDTO>> RegisterWithOtp(RegisterWithOtp.Command command)
        {
            return await Mediator.Send(command);
        }
    }
}