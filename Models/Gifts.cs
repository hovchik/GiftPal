using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Gifts
    {
        public int Id { get; set; }
        public string GiftName { get; set; }
        public string Url { get; set; }
        public decimal Price { get; set; }

        public string ImageUrl { get; set; }

        public bool? IsSend { get; set; }
        public bool? IsReceived { get; set; }
        
    }
}
