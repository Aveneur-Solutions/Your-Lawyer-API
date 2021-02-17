using System.Collections.Generic;
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
    public class LawyerListWithParameters
    {

        public class Query : IRequest<List<LawyerDTO>>
        {
            public string DivisionName { get; set; }
            public string AreaOfLawName { get; set; }
        }

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

                Division division = null;

                var lawyers = from l in _context.Lawyers select l;
                //if the user searches for lawyer by division 
                if (!string.IsNullOrEmpty(request.DivisionName))
                {
                    // Changing case of Division name to ignore case mismatching problem by using ToLower method
                    division = await _context.Divisions.FirstOrDefaultAsync(x => x.Name.ToLower() == request.DivisionName.ToLower());
                    if (division == null) throw new System.Exception("no Such division exists");
                    lawyers = lawyers.Where(x => x.DivisionId == division.Id);
                }

                var Lawyers = await lawyers.
                Include(x => x.Division).
                Include(x => x.LawyersAreaOfLaws)
                 .ThenInclude(y => y.AreaOfLaw)
                .Include(x => x.LawyerEducationalBGs)
                .ToListAsync();

                //Console.WriteLine(DivisionList.Divisions[2]);

                return _mapper.Map<List<Lawyer>, List<LawyerDTO>>(Lawyers);

                //throw new System.NotImplementedException();
            }
        }
    }
}