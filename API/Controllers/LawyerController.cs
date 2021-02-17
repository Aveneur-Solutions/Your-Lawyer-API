using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.LawyerService;
using Domain.DTOs;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    public class LawyerController : BaseController
    {
        [Route("")]
        [Route("api/lawyer")]
        [HttpGet]
        public async Task<ActionResult<List<LawyerDTO>>> LawyerList()
        {
            Console.WriteLine("Hi");
            return await Mediator.Send(new LawyerList.Query());
        }


        [Route("api/lawyer/{id}")]
        [HttpGet]
        public async Task<ActionResult<LawyerDTO>> LawyerDetails(Guid id)
        {
            return await Mediator.Send(new LawyerDetails.Query { Id = id });
        }
        [Route("api/searchlawyers/{divisionName}")]
        [HttpGet]

        public async Task<ActionResult<List<LawyerDTO>>> LawyerListWithParameters(string divisionName)
        {
            
            return await Mediator.Send(new LawyerListWithParameters.Query { DivisionName = divisionName });
        }
        
        [Route("api/upload")]
        [HttpPost]
        public async Task<ActionResult<Unit>> UploadLawyer(UploadLawyer.Command command)
        {
            return await Mediator.Send(command);
        }

    }
}