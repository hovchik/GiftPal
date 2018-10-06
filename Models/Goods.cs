//using System;
//using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations.Schema;
//using System.Text;

//namespace Models
//{
//    public class Goods
//    {
//        public int Id { get; set; }
//        // public virtual Gifts Gifts { get; set; }
//        //[ForeignKey("SentGoods")]
//        public int? SentGoodsId { get; set; }
//        public SentGoods SentGoods { get; set; }

//        //[ForeignKey("ReceivedGoods")]
//        public int? ReceivedGoodsId { get; set; }
//        public virtual ReceivedGoods ReceivedGoods { get; set; }

//        //[ForeignKey("Users")]
//        public int UserId { get; set; }
//        public Users User { get; set; }

//        public ICollection<UserRelations> UserRelationses { get; set; }

//        public Goods()
//        {
//            UserRelationses = new List<UserRelations>();
//        }
//    }
//}
