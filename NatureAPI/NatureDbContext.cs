using Microsoft.EntityFrameworkCore;
using NatureAPI.Models.Entities;

namespace NatureAPI;

public class NatureDbContext : DbContext
{
    public DbSet<Place> Places { get; set; }
    public DbSet<Trail> Trails { get; set; }
    public DbSet<Photo> Photos { get; set; }
    public DbSet<Review> Reviews { get; set; }
    public DbSet<Amenity> Amenities { get; set; }
    public DbSet<PlaceAmenity> PlaceAmenities { get; set; }

    public NatureDbContext(DbContextOptions<NatureDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<PlaceAmenity>()
            .HasKey(pa => new { pa.PlaceId, pa.AmenityId });
        
        modelBuilder.Entity<Trail>()
            .HasOne(t => t.Place)
            .WithMany(p => p.Trails)
            .HasForeignKey(t => t.PlaceId);

        modelBuilder.Entity<Photo>()
            .HasOne(p => p.Place)
            .WithMany(pl => pl.Photos)
            .HasForeignKey(p => p.PlaceId);

        modelBuilder.Entity<Review>()
            .HasOne(r => r.Place)
            .WithMany(p => p.Reviews)
            .HasForeignKey(r => r.PlaceId);
        
        // Relaciones N-N
        modelBuilder.Entity<PlaceAmenity>()
            .HasOne(pa => pa.Place)
            .WithMany(p => p.PlaceAmenities)
            .HasForeignKey(pa => pa.PlaceId);
        
        modelBuilder.Entity<PlaceAmenity>()
            .HasOne(pa => pa.Amenity)
            .WithMany(a => a.PlaceAmenities)
            .HasForeignKey(pa => pa.AmenityId);
    }
}