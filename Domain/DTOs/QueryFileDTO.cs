using System;

namespace Domain.DTOs
{
    public class QueryFileDTO
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string SenderName { get; set; }
        public string ReceiverName { get; set; }
        public string FilePath { get; set; }
    }
}