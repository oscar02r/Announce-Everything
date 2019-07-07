
using AnnounceEverything.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AnnounceEverything.Data
{
    public class DataContext : IdentityDbContext<AppUser>
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        #region Properties to become tables on datases

        public DbSet<Announce> Announces { get; set; }

        public DbSet<Province> Provinces { get; set; }

        public DbSet<Condition> Conditions { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<UserKind> UserKinds { get; set; }

        #endregion

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

        }
    }
}
