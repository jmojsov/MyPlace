using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.ViewModels
{
    public class PictureCreateModel
    {
        public string ImageUrl { get; set; }
        public string Email { get; set; }
        public bool IsPrivate { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
