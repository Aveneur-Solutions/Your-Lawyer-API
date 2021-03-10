using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.LawyerService;
using Domain.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{

    [ApiController]
    public class LawyerController : BaseController
    {
        
        [HttpGet]
        public async Task<ActionResult<List<LawyerDTO>>> LawyerList()
        {
            // Console.WriteLine("Hi");
            return await Mediator.Send(new LawyerList.Query());
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<LawyerDTO>> LawyerDetails(Guid id)
        {
            return await Mediator.Send(new LawyerDetails.Query { Id = id });
        }
   
        [HttpGet("params")]

        public async Task<ActionResult<List<LawyerDTO>>> LawyerListWithParameters(LawyerListWithParameters.Query query)
        {
            
            return await Mediator.Send(query);
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> UploadLawyer(UploadLawyer.Command command)
        {
            return await Mediator.Send(command);
        }

    }
}