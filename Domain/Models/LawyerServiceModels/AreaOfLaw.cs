using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class AreaOfLaw
    {
        public Guid Id { get; set; }
        public string AreaOfLawName { get; set; }
        public ICollection<LawyerAndAreaOfLaw> LawyersUnderThisAreaOfLaw { get; set; }
    }
}