using ChallengeNubi.Core.Entities;
using ChallengeNubi.Infrastructure.Data.Configurations;
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
            modelBuilder.ApplyConfiguration(new UserConfiguration());

        }       
    }
}
