using System;

namespace Domain.Models
{
    public class LawyerAndAreaOfLaw
    {
        public Guid Id { get; set; }
       public Guid LawyerId { get; set; }
       public Lawyer Lawyer { get; set; }
       public Guid AreaOfLawId { get; set; }
       public AreaOfLaw AreaOfLaw { get; set; }
       
    }
}