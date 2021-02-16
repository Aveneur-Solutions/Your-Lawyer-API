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
             //   var lawyerEducationBGs = new List<LawyerEducationalBG>{

             //   };
                var lawyers = new List<Lawyer>
                 {
                     new Lawyer{
                         FirstName="Zunaid",
                         LastName="Amin Enan",
                         Location="Banani",
                         Description="Zunaid Amin Enan is an experienced and dedicated trial lawyer who focuses his litigation practice on defending employers and employees in labor and employment litigation, class action wage and hour litigation, commercial litigation and white collar criminal defense. He provides advice to employers on various wage and hour and employment-related issues, including internal and external investigations. He further defends businesses and individuals involved in civil, administrative or criminal government investigations or proceedings.",
                         ProfileImageLocation="/images/image.jpg",
                         WorkingExperience=10,
                         Division = division,
                         LawyerRank="Elite",
                         LawyerEducationalBGs = new List<LawyerEducationalBG>{
                              new LawyerEducationalBG{
                                  Degree ="LLB",
                                  Institute = "IUB",
                                  PassingYear = 2020
                              },
                               new LawyerEducationalBG{
                                  Degree ="MLB",
                                  Institute = "IUB",
                                  PassingYear = 2022
                              },
                               new LawyerEducationalBG{
                                  Degree ="PLB",
                                  Institute = "IUB",
                                  PassingYear = 2022
                              }
                         }
                         },
                            new Lawyer{
                         FirstName="Zulker",
                         LastName="Rahman Nien",
                         Location="Dhanmondi",
                         Description="Zulker Rahman Nien is an experienced and dedicated trial lawyer who focuses his litigation practice on defending employers and employees in labor and employment litigation, class action wage and hour litigation, commercial litigation and white collar criminal defense. He provides advice to employers on various wage and hour and employment-related issues, including internal and external investigations. He further defends businesses and individuals involved in civil, administrative or criminal government investigations or proceedings.",
                         ProfileImageLocation="/images/image.jpg",
                         WorkingExperience=10,
                         Division = division,
                         LawyerRank="Elite",
                           LawyerEducationalBGs = new List<LawyerEducationalBG>{
                              new LawyerEducationalBG{
                                  Degree ="LLB",
                                  Institute = "IUB",
                                  PassingYear = 2020
                              }
                         }
                         },
                            new Lawyer{
                         FirstName="Ashikur ",
                         LastName="Shikdar Noyon",
                         Location="Bashundhara",
                         Description="Zunaid Amin Enan is an experienced and dedicated trial lawyer who focuses his litigation practice on defending employers and employees in labor and employment litigation, class action wage and hour litigation, commercial litigation and white collar criminal defense. He provides advice to employers on various wage and hour and employment-related issues, including internal and external investigations. He further defends businesses and individuals involved in civil, administrative or criminal government investigations or proceedings.",
                         ProfileImageLocation="/images/image.jpg",
                         WorkingExperience=10,
                         Division = division,
                         LawyerRank="Elite",
                           LawyerEducationalBGs = new List<LawyerEducationalBG>{
                              new LawyerEducationalBG{
                                  Degree ="LLB",
                                  Institute = "IUB",
                                  PassingYear = 2020
                              }
                         }
                         }
                     };
                await context.Lawyers.AddRangeAsync(lawyers);
                await context.SaveChangesAsync();
            }

        }
    }
}