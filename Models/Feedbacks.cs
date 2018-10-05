using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Models
{
    public class Feedbacks
    {
        public int Id { get; set; }
        [ForeignKey("Users")]
        public int UserId { get; set; }
        public Users Users { get; set; }
        [Required]
        public string Feedback { get; set; }
        public bool Deleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
