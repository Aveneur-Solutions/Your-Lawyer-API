using System;

namespace Domain.Models
{
    public class LawyerEducationalBG
    {
        public int Id { get; set; }
        public string Degree { get; set; }
        public string Institute { get; set; }
        public int PassingYear { get; set; }
        public Guid LawyerId { get; set; }
        public Lawyer Lawyer { get; set; }
    }
}