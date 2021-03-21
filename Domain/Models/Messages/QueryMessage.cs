using System;
using Domain.Models.User;

namespace Domain.Models.Messages
{
    public abstract class QueryMessage
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public AppUser Sender { get; set; }
        public string SenderId { get; set; }
        public AppUser Receiver { get; set; }
        public string ReceiverId { get; set; }
    }

    public class QueryText : QueryMessage {
        
        public string Text { get; set; }
    }

    public class QueryFile : QueryMessage {
        public string FilePath { get; set; }
    }
}