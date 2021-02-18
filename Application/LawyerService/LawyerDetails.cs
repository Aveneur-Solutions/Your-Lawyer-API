using System;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using AutoMapper;
using Domain.DTOs;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Application.LawyerService
{
    public class LawyerDetails
    {
        public class Query : IRequest<LawyerDTO>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, LawyerDTO>
        {
            private readonly YourLawyerContext _context;
            private readonly IMapper _mapper;
            public Handler(YourLawyerContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<LawyerDTO> Handle(Query request, CancellationToken cancellationToken)
            {

              
                
                var lawyer = await _context.Lawyers
                .Include(x=> x.Division)
                .Include(x => x.LawyersAreaOfLaws)
                  .ThenInclude( y => y.AreaOfLaw)
                .Include(x => x.LawyerEducationalBGs)
                .FirstOrDefaultAsync(x => x.Id == request.Id);

                if (lawyer == null) throw new RestException(HttpStatusCode.NotFound, new { lawyer = "Not Found" });
                
                return _mapper.Map<Lawyer, LawyerDTO>(lawyer);

                //throw new System.NotImplementedException();
            }
        }
    }
}