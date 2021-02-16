using System;
using System.Collections.Generic;
using Domain.Models;

namespace Domain.DTOs
{
    public class LawyerDTO
    {

        // Not Complete yet Need Some Modifications
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Description { get; set; }
        public string LawyerRank { get; set; }
        public string ProfileImageLocation { get; set; }
        public int WorkingExperience { get; set; }
        public ICollection<LawyerEducationalBGDTO> Degrees { get; set; }
         public ICollection<AreaOfLawDTO> LawyersAreaOfLaws { get; set; }
        public string DivisionName { get; set; }

    }
}