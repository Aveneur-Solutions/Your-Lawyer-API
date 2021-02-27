using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Lawyer
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Location { get; set; }
        public string LawyerRank { get; set; }
        public string Description { get; set; }
        public string ProfileImageLocation { get; set; }
        public int WorkingExperience { get; set; }
        public ICollection<LawyerAndAreaOfLaw> LawyersAreaOfLaws { get; set; }
        public Guid DivisionId { get; set; }
        public Division Division { get; set; }
        public ICollection<LawyerEducationalBG> LawyerEducationalBGs { get; set; }
    }
}