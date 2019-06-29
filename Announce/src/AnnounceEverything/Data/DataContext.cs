using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AnnounceEverything.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnnounceEverything.Models
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        public DbSet<Announce> Announces { get; set; }

        public DbSet<Province> Provinces { get; set; }

        public DbSet<Condition> Conditions { get; set; }

        public DbSet<Category> Categories { get; set; }

        public  DbSet<UserKind> UserKinds { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
           
        }
    }
}
