using System.Collections.Generic;
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


    // Lists generic parameter should be LawyerDTO . Keeping it lawyer for the time being
    public class LawyerList
    {
               public class Query : IRequest<List<Lawyer>> { }

        public class Handler : IRequestHandler<Query, List<Lawyer>>
        {
            private readonly YourLawyerContext _context;
            private readonly IMapper _mapper;
            public Handler(YourLawyerContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<List<Lawyer>> Handle(Query request, CancellationToken cancellationToken)
            {
                var lawyers = await _context.Lawyers.ToListAsync();

                return (lawyers);

                //throw new System.NotImplementedException();
            }
        }
    }
}