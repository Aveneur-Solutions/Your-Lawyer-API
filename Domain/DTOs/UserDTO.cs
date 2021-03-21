using System.Collections.Generic;

namespace Domain.DTOs
{
    public class UserDTO
    {
        public string FullName { get; set; }
        public string Token { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<QueryTextDTO> SentQueryTexts { get; set; }
        public ICollection<QueryTextDTO> ReceivedQueryTexts { get; set; }
        public ICollection<QueryFileDTO> SentQueryFiles { get; set; }
        public ICollection<QueryFileDTO> ReceivedQueryFiles { get; set; }
    }
}