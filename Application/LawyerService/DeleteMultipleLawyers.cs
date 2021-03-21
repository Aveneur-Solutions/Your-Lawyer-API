using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using Domain.Models;
using FluentValidation;
using MediatR;
using Persistence.DataContext;

namespace Application.LawyerService
{
    public class DeleteMultipleLawyers
    {
                public class Command : IRequest
        {
            public List<Guid> Ids { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Ids).NotEmpty();
            }
        }
        public class Handler : IRequestHandler<Command>
        {
            private readonly YourLawyerContext _context;
            public Handler(YourLawyerContext context)
            {
                _context = context;
            }

            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                 var lawyerListToBeDeleted =new List<Lawyer>();
                 Lawyer lawyer = null;
                if(request.Ids.Count > 0)
                {
                    
                    foreach (var id in request.Ids)
                    {
                     lawyer =await _context.Lawyers.FindAsync(id);

                     if(lawyer == null) continue;
                     
                    lawyerListToBeDeleted.Add(lawyer);
                                   
                    }
                }
              
                 if(lawyerListToBeDeleted.Count == 0 ) throw new RestException(HttpStatusCode.NotFound,new {error = "No lawyer found with the ids given"});
                 
                  _context.RemoveRange(lawyerListToBeDeleted);
                  var result = await _context.SaveChangesAsync() > 0;
                  if(result) return Unit.Value;
                
                 throw new RestException(HttpStatusCode.InternalServerError,new {error = "Ei statement jiboneo hit korar kotha na jodi kore taile delete hoi nai"});
            }
        }
    }
}