using System.Threading.Tasks;
using Application.UserAuth;
using Domain.DTOs;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class UserController : BaseController
    {
        [Route("user/login")]
        [HttpPost]
        public async Task<ActionResult<UserDTO>> Login(Login.Query query)
        {
            return await Mediator.Send(query);
        }

        [Route("user")]
        [HttpGet]
        public async Task<ActionResult<UserDTO>> CurrentUser()
        {
            return await Mediator.Send(new CurrentUser.Query());
        }
    }
}