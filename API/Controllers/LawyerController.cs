using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Application.LawyerService;
using Domain.DTOs;
using MediatR;
using Microsoft.AspNetCore.Authorization;
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
   
        [HttpGet("division/{divisionName}")]

        public async Task<ActionResult<List<LawyerDTO>>> LawyerListWithParameters(string divisionName)
        {
            return await Mediator.Send(new LawyerListWithParameters.Query {DivisionName = divisionName});
        }

        [HttpPost]
        public async Task<ActionResult<Unit>> UploadLawyer(UploadLawyer.Command command)
        {
            return await Mediator.Send(command);
        }
        [HttpDelete]
        //For testing purpose its anonymous
        public async Task<ActionResult<Unit>> DeleteLawyer(DeleteLawyer.Command command)
        {
            return await Mediator.Send(command);
        }
        [HttpDelete("deletemultiple")]
         //For testing purpose its anonymous
        public async Task<ActionResult<Unit>> DeleteMultipleLawyers(DeleteMultipleLawyers.Command command)
        {
            return await Mediator.Send(command);
        }

        //  [HttpPut("{id}")]
        //  [AllowAnonymous]
        // public async Task<ActionResult<Unit>> UpdateLawyer(Guid id,UpdateLawyer.Command command)
        // {
        //     command.Id = id;
        //     return await Mediator.Send(command);
        // }

    }
}