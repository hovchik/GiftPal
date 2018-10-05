using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class SentGoods
    {
        public int Id { get; set; }
        //[ForeignKey("Gifts")]
        public int GiftId { get; set; }
        public Gifts Gift { get; set; }

        public bool IsSent { get; set; }

        public bool Deleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
