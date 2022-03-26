using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace travellerinfoAPI.Models
{
    public partial class TravellerinfoContext : DbContext
    {
        public TravellerinfoContext()
        {
        }

        public TravellerinfoContext(DbContextOptions<TravellerinfoContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TravellersDetails> TravellersDetails { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=localhost;Database=Travellerinfo;Integrated security=true");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TravellersDetails>(entity =>
            {
                entity.ToTable("travellers_details");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Boarding).HasMaxLength(50);

                entity.Property(e => e.Destination).HasMaxLength(50);

                entity.Property(e => e.Mobile).HasMaxLength(50);

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.Transport).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
