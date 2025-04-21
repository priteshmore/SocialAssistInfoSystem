using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SocialAssistInfoSystem.Data.DBEntity;
using System.Reflection.Emit;

namespace SocialAssistInfoSystem.Data
{
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
    {
        public DbSet<Application> Applications { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Application <-> Scheme
            builder.Entity<Application>()
                .HasOne(a => a.Scheme)
                .WithOne(s => s.Application)
                .HasForeignKey<Scheme>(s => s.ApplicationId)
                .OnDelete(DeleteBehavior.Cascade);

            // Application <-> Address
            builder.Entity<Application>()
                .HasOne(a => a.Address)
                .WithOne(ad => ad.Application)
                .HasForeignKey<Address>(ad => ad.ApplicationId)
                .OnDelete(DeleteBehavior.Cascade);

            // Application <-> Profile
            builder.Entity<Application>()
                .HasOne(a => a.Profile)
                .WithOne(p => p.Application)
                .HasForeignKey<Profile>(p => p.ApplicationId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
