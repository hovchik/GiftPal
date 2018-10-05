using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class ShippingAddress
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        [Required]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Zip { get; set; }
        [Required]
        public string Country { get; set; }

        public Users User { get; set; } 
    }
}
