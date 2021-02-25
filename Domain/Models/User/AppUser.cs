using System.Collections.Generic;
using Domain.Models.Messages;
using Microsoft.AspNetCore.Identity;

namespace Domain.Models.User
{
    public class AppUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public ICollection<QueryText> SentQueryTexts { get; set; }
        public ICollection<QueryFile> SentQueryFiles { get; set; }
        public ICollection<QueryText> ReceivedQueryTexts { get; set; }
        public ICollection<QueryFile> ReceivedQueryFiles { get; set; }
    }
}