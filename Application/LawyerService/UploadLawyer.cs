using System;
using System.Threading;
using System.Threading.Tasks;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Application.LawyerService
{
    public class UploadLawyer
    {
        public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Location { get; set; }
            public string Degree { get; set; }
            public string Description { get; set; }
            public DateTime StartingOfficeHour { get; set; }
            public DateTime EndingOfficeHour { get; set; }
            public string ProfileImageLocation { get; set; }
            public int WorkingExperience { get; set; }
            public string DivisionName { get; set; }

        }
        // public class CommandValidator : AbstractValidator<Command>
        // {
        //     public CommandValidator()
        //     {
        //         RuleFor(x => x.Title).NotEmpty();
        //         RuleFor(x => x.Description).NotEmpty();
        //         RuleFor(x => x.Date).NotEmpty();
        //         RuleFor(x => x.Category).NotEmpty();
        //         RuleFor(x => x.City).NotEmpty();
        //         RuleFor(x => x.Venue).NotEmpty();
        //     }

        // }
        public class Handler : IRequestHandler<Command>
        {
            private readonly YourLawyerContext _context;
            // private readonly IUserAccessor _userAccessor;
            public Handler(YourLawyerContext context)
            {
                // _userAccessor = userAccessor;
                _context = context;
            }
            public async Task<Unit> Handle(Command request, CancellationToken cancellationToken)
            {
                var division = await _context.Divisions.SingleOrDefaultAsync(x => x.Name == request.DivisionName);

                var lawyer = new Lawyer
                {
                    Id = request.Id,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Description = request.Description,
                    ProfileImageLocation = request.ProfileImageLocation,
                    StartingOfficeHour = request.StartingOfficeHour,
                    EndingOfficeHour=request.EndingOfficeHour,
                    Degree = request.Degree,
                    DivisionId = division.Id,
                    WorkingExperience=request.WorkingExperience,
                    Location = request.Location
                   
                };
                _context.Lawyers.Add(lawyer);

            

                var result = await _context.SaveChangesAsync() > 0;

                if (result) return Unit.Value;

                throw new Exception("Problem saving data");

            }
        }
    }
}