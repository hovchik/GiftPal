using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Goods
    {
        public int Id { get; set; }
        // public virtual Gifts Gifts { get; set; }

        public int SentGoodsId { get; set; }
        public SentGoods SentGoods { get; set; }

        public int ReceivedGoodsId { get; set; }
        public virtual ReceivedGoods ReceivedGoods { get; set; }

        public int UserId { get; set; }
        public Users Users { get; set; }
    }
}
