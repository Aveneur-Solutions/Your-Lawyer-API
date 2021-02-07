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
    [Route("api/[controller]")]
    [ApiController]
    public class LawyerController : BaseController
    {

        [HttpGet] 
        public async Task<ActionResult<List<Lawyer>>> LawyerList()
        {
            return await Mediator.Send(new LawyerList.Query());
        }
         [HttpGet("{id}")] 
        public async Task<ActionResult<Lawyer>> LawyerDetails(Guid id)
        {
            
            return await Mediator.Send(new LawyerDetails.Query{Id = id});
        }
          [HttpGet("/divisionList")] 
        public async Task<ActionResult<List<Division>>> DivisionList()
        {
            return await Mediator.Send(new DivisionList.Query());
        }
    }
}