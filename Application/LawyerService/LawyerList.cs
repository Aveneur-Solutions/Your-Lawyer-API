using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using Domain.DTOs;
using Domain.Models;
using Domain.StaticModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Application.LawyerService
{


    // Lists generic parameter should be LawyerDTO . Keeping it lawyer for the time being
    public class LawyerList
    {
        public class Query : IRequest<List<LawyerDTO>> { }

        public class Handler : IRequestHandler<Query, List<LawyerDTO>>
        {
            private readonly YourLawyerContext _context;
            private readonly IMapper _mapper;
            public Handler(YourLawyerContext context, IMapper mapper)
            {
                _mapper = mapper;
                _context = context;
            }

            public async Task<List<LawyerDTO>> Handle(Query request, CancellationToken cancellationToken)
            {
                var lawyers = await _context.Lawyers.
                Include(x => x.Division).
                Include(x => x.LawyersAreaOfLaws)
                .ToListAsync();



                return _mapper.Map<List<Lawyer>, List<LawyerDTO>>(lawyers);

                //throw new System.NotImplementedException();
            }
        }
    }
}