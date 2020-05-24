using ChallengeNubi.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace ChallengeNubi.Infrastructure.Data
{
    public partial class ChallengeNubiContext : DbContext
    {
        public ChallengeNubiContext()
        {
        }

        public ChallengeNubiContext(DbContextOptions<ChallengeNubiContext> options)
            : base(options)
        {
        }

        public virtual DbSet<User> User { get; set; }        

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>(entity =>
            {
                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

        }       
    }
}
