using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Persistence.DataContext;

namespace Application.LawyerService
{
    public class EditLawyer
    {
              public class Command : IRequest
        {
            public Guid Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Location { get; set; }
            public ICollection<LawyerEducationalBG> Degrees { get; set; }
            public string Description { get; set; }
            public string ProfileImageLocation { get; set; }
            public int WorkingExperience { get; set; }
            public string DivisionName { get; set; }
            public string Rank { get; set; }
            public ICollection<string> LawyerAndAreaOfLaws { get; set; }

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

                // searching for the division instance in datbase by division name 
                var division = await _context.Divisions.SingleOrDefaultAsync(x => x.Name == request.DivisionName);
                var lawyer = new Lawyer
                {
                    // Id = request.Id,
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Description = request.Description,
                    ProfileImageLocation = request.ProfileImageLocation,
                    Division = division,
                    WorkingExperience = request.WorkingExperience,
                    LawyerEducationalBGs = request.Degrees,
                    LawyerRank = request.Rank

                };

                try
                {
                    var lawyerAndAreaOfLawList = new List<LawyerAndAreaOfLaw> { };

                    //iterates the LawyerAreaOfLaws from the request and adds each 
                    foreach (var areaOflaw in request.LawyerAndAreaOfLaws)
                    {
                        // Searches for the areaOfLaw instance from database by areaoflaw name
                        var areaOfLaw = await _context.AreaOfLaws.SingleOrDefaultAsync(x => x.AreaOfLawName == areaOflaw);

                        // Creating new lawyerAndAreaOfLaw to add them in the list
                        var lawyerAndAreaOfLaw = new LawyerAndAreaOfLaw
                        {
                            Lawyer = lawyer,
                            AreaOfLaw = areaOfLaw
                        };
                        lawyerAndAreaOfLawList.Add(lawyerAndAreaOfLaw);
                    }
                    //Adding the lawyer to Lawyers table 
                    await _context.Lawyers.AddAsync(lawyer);
                    // Adding the lawyerAndAreaOfLaw list to the lawyer and area of law table
                    await _context.LawyerAndAreaOfLaws.AddRangeAsync(lawyerAndAreaOfLawList);
                    var result = await _context.SaveChangesAsync() > 0;
                     if (result) return Unit.Value;
                }
                catch (Exception ex)
                {
                    throw (ex);
                }
                // this lawyer instance is created to be added Lawyers table 


                // List to add all area of laws of one lawyer


                // The previous methods tracks the instances as submittable to database 
                //the method below submits the tracked data .
                // this method returns 0 if data is successfully submitted 
                

               

                throw new Exception("Problem saving data");

            }
        }
    }
}