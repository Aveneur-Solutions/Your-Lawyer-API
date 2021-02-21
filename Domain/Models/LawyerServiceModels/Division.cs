using System;
using System.Collections.Generic;

namespace Domain.Models
{
    public class Division
    {

        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Lawyer> Lawyers { get; set; }
    }
}