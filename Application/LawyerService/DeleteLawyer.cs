using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using Application.Errors;
using FluentValidation;
using MediatR;
using Persistence.DataContext;

namespace Application.LawyerService
{
    public class DeleteLawyer
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
        }

        public class CommandValidator : AbstractValidator<Command>
        {
            public CommandValidator()
            {
                RuleFor(x => x.Id).NotEmpty();
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
                var lawyer = await _context.Lawyers.FindAsync(request.Id);
                if(lawyer == null) throw new RestException(HttpStatusCode.NotFound,new {error = "No Lawyer found"});
                 
                  _context.Remove(lawyer);
                  var result = await _context.SaveChangesAsync() > 0;
                  if(result) return Unit.Value;
                
                 throw new RestException(HttpStatusCode.InternalServerError,new {error = "Ei statement jiboneo hit korar kotha na jodi kore taile delete hoi nai"});
            }
        }
    }
}