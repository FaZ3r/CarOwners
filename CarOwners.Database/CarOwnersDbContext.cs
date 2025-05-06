using Microsoft.EntityFrameworkCore;
using CarOwners.Database.Entities;

namespace CarOwners.Database
{
    public class CarOwnersDbContext : DbContext
    {
        public CarOwnersDbContext(DbContextOptions<CarOwnersDbContext> options)
            : base(options)
        {
        }

        public DbSet<Proprietar> Proprietari { get; set; }
        public DbSet<Masina> Masini { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Proprietar>()
                .HasMany(p => p.Masini)
                .WithOne(m => m.Proprietar)
                .HasForeignKey(m => m.ProprietarId);
        }
    }
}