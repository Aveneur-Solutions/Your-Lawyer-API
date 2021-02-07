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
        public string Location { get; set; }
        public string Degree { get; set; }
        public string Description { get; set; }
        public DateTime StartingOfficeHour { get; set; }
        public DateTime EndingOfficeHour { get; set; }
        public string ProfileImageLocation { get; set; }
        public int WorkingExperience { get; set; }
        public ICollection<LawyerAndAreaOfLaw> LawyersAreaOfLaws { get; set; }
        public Guid DivisionId { get; set; }
        public Division Division { get; set; }
    }
}