using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class TestController : BaseController
    {
        [HttpGet("altufaltu")]
        [AllowAnonymous]
        public async Task<IActionResult> ClickMe()
        {
            return Ok("Hi");
        }
    }
}