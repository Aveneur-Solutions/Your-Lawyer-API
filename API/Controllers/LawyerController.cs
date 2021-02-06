using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LawyerController : ControllerBase
    {
        public LawyerController()
        {

        }

        [HttpGet]
        public ActionResult<string> Get(){

          return "Hello Madafaka";
        }
        [HttpGet("{name}")]
        public ActionResult<string> Get(string name){

          return Ok(name);
        }
    }
}