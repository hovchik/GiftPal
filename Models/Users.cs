﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public DateTime BirthDay { get; set; }
        [Required]
        public string Email { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public bool Deleted { get; set; }

        public ICollection<UserRelations> UserRelations { get; set; }
        public ICollection<UserRelations> UserRelations2 { get; set; }
        public ICollection<ShippingAddress> ShippingAddress { get; set; }
        public ICollection<Feedbacks> Feedbacks { get; set; }

    }
}
