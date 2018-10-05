using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class SentGoods
    {
        public int Id { get; set; }
        public int GiftId { get; set; }
        public Gifts Gifts { get; set; }

        public bool IsSent { get; set; }

        public bool Deleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
