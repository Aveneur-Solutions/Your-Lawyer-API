using System.Collections.Generic;

namespace Domain.DTOs
{
    public class UserDTO
    {
        public string UserName { get; set; }
        public string Token { get; set; }
        public string Email { get; set; }
        public ICollection<QueryTextDTO> SentQueryTexts { get; set; }
        public ICollection<QueryTextDTO> ReceivedQueryTexts { get; set; }
    }
}