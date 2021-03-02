using System;
using System.Collections;
using System.Collections.Generic;

namespace Domain.DTOs
{
    public class QueryMessageDTO
    {
        public ICollection<QueryTextDTO> QueryTexts { get; set; }
    }
}