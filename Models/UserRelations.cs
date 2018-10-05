using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    public class UserRelations
    {
        public int Id { get; set; }
        [Required, ForeignKey("User")]
        public int SourceID { get; set; }
        [Required, ForeignKey("User2")]
        public int DestinationID { get; set; }
        [Required, ForeignKey("Good")]
        public int GoodID { get; set; }
        public bool IsSent { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }

        public Users User { get; set; }
        public Users User2 { get; set; }
        public Goods Good { get; set; }

    }
}
