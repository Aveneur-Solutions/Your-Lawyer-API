using System;

namespace Domain.DTOs
{
    public class QueryTextDTO
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public string Text { get; set; }
    }
}