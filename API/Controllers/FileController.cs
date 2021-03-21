using System.Threading.Tasks;
using Application.QueryFiles;
using Domain.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class FileController : BaseController
    {
        [HttpPost("file")]
        public async Task<ActionResult<QueryFileDTO>> UploadToLegalx([FromForm]UploadToLegalx.Command command)
        {
            return await Mediator.Send(command);
        }

        [HttpPost("filex")]
        public async Task<ActionResult<QueryFileDTO>> UploadToUser([FromForm]UploadToUser.Command command )
        {


            
            return await Mediator.Send(command);
        }
    }
}