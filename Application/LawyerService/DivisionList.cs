using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Application.LawyerService
{
    public class DivisionList
    {
        public class Query : IRequest<List<Division>> { }

        public class Handler : IRequestHandler<Query, List<Division>>
        {
            private readonly YourLawyerContext _context;
            private readonly IMapper _mapper;
            public Handler(YourLawyerContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<List<Division>> Handle(Query request, CancellationToken cancellationToken)
            {
                var divisions = await _context.Divisions.ToListAsync();

                return (divisions);

                //throw new System.NotImplementedException();
            }
        }
    }
}