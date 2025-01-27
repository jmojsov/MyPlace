﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Models
{
    public class Picture
    {
        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public bool IsPrivate { get; set; }
        [Required]
        public DateTime DateCreated { get; set; }
    }
}
