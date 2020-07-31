using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Models
{
    public class MyPlaceDbContext : IdentityDbContext
    {
        public MyPlaceDbContext(DbContextOptions<MyPlaceDbContext> options) : base(options)
        {
        }
        public DbSet<Picture> Pictures { get; set; }
    }
}
