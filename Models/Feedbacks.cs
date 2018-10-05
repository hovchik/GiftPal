using System;
using System.Collections.Generic;
using System.Text;

namespace Models
{
    public class Feedbacks
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public Users Users { get; set; }
        public string Feedback { get; set; }
        public bool Deleted { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
