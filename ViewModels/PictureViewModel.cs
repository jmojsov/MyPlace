﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.ViewModels
{
    public class PictureViewModel
    {
        public int Id { get; set; }
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
