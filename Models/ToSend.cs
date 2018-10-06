using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class ToSend
    {
        public int Id { get; set; }
        public int SourceId { get; set; }
        public int GiftId { get; set; }
        public Gifts Gift { get; set; }
        public int DestinationId { get; set; }
        public Users Source { get; set; }
        public Users Destination { get; set; }
        public bool IsSending { get; set; }
    }
}
