using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
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
                .FirstOrDefaultAsync(x => x.Id == request.Id);

                return _mapper.Map<Lawyer,LawyerDTO>(lawyer);

                //throw new System.NotImplementedException();
            }
        }
    }
}