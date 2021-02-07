using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Models;
using Persistence.DataContext;

namespace Persistence.Initialization
{
    public class Seed
    {
        public static async Task SeedData(YourLawyerContext context)
        {

            // Incomplete

            if (!context.Lawyers.Any())
            {
                var division = context.Divisions.FirstOrDefault();

                var lawyers = new List<Lawyer>
                 {
                     new Lawyer{
                         FirstName="Zunaid",
                         LastName="Amin Enan",
                         Location="Banani",
                         Degree="LLB",
                         Description="Zunaid Amin Enan is an experienced and dedicated trial lawyer who focuses his litigation practice on defending employers and employees in labor and employment litigation, class action wage and hour litigation, commercial litigation and white collar criminal defense. He provides advice to employers on various wage and hour and employment-related issues, including internal and external investigations. He further defends businesses and individuals involved in civil, administrative or criminal government investigations or proceedings.",
                         StartingOfficeHour=DateTime.Now,
                         EndingOfficeHour=DateTime.Today,
                         ProfileImageLocation="/images/image.jpg",
                         WorkingExperience=10,
                         Division = division,

                         },
                            new Lawyer{
                         FirstName="Zulker",
                         LastName="Rahman Nien",
                         Location="Dhanmondi",
                         Degree="LLB",
                         Description="Zulker Rahman Nien is an experienced and dedicated trial lawyer who focuses his litigation practice on defending employers and employees in labor and employment litigation, class action wage and hour litigation, commercial litigation and white collar criminal defense. He provides advice to employers on various wage and hour and employment-related issues, including internal and external investigations. He further defends businesses and individuals involved in civil, administrative or criminal government investigations or proceedings.",
                         StartingOfficeHour=DateTime.Now,
                         EndingOfficeHour=DateTime.Today,
                         ProfileImageLocation="/images/image.jpg",
                         WorkingExperience=10,
                         Division = division,

                         },
                            new Lawyer{
                         FirstName="Ashikur ",
                         LastName="Shikdar Noyon",
                         Location="Bashundhara",
                         Degree="LLB",
                         Description="Zunaid Amin Enan is an experienced and dedicated trial lawyer who focuses his litigation practice on defending employers and employees in labor and employment litigation, class action wage and hour litigation, commercial litigation and white collar criminal defense. He provides advice to employers on various wage and hour and employment-related issues, including internal and external investigations. He further defends businesses and individuals involved in civil, administrative or criminal government investigations or proceedings.",
                         StartingOfficeHour=DateTime.Now,
                         EndingOfficeHour=DateTime.Today,
                         ProfileImageLocation="/images/image.jpg",
                         WorkingExperience=10,
                         Division = division,

                         }


                     };
                await context.Lawyers.AddRangeAsync(lawyers);
                await context.SaveChangesAsync();
            }

        }
    }
}