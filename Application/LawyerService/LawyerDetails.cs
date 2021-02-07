using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Application.LawyerService
{
    public class LawyerDetails
    {
        public class Query : IRequest<Lawyer>
        {
            public Guid Id { get; set; }
        }

        public class Handler : IRequestHandler<Query, Lawyer>
        {
            private readonly YourLawyerContext _context;
            private readonly IMapper _mapper;
            public Handler(YourLawyerContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<Lawyer> Handle(Query request, CancellationToken cancellationToken)
            {
                var lawyer = await _context.Lawyers.FirstOrDefaultAsync(x => x.Id == request.Id);

                return (lawyer);

                //throw new System.NotImplementedException();
            }
        }
    }
}