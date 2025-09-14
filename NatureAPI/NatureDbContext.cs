using Microsoft.EntityFrameworkCore;
using NatureAPI.Models.Entities;

namespace NatureAPI;

public class NatureDbContext : DbContext
{
    public DbSet<Place> Place { get; set; }
    public DbSet<Trail> Trail { get; set; }
    public DbSet<Photo> Photo { get; set; }
    public DbSet<Review> Review { get; set; }
    public DbSet<Amenity> Amenity { get; set; }
    public DbSet<PlaceAmenity> PlaceAmenity { get; set; }

    public NatureDbContext(DbContextOptions<NatureDbContext> options) : base(options)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        modelBuilder.Entity<PlaceAmenity>().HasKey(p => new{p.PlaceId, p.AmenityId});

        modelBuilder.Entity<Place>().HasData(
            new Place
            {
                Id = 1,
                Name = "Nature",
                Description = "Nature",
                Category = "Nature",
                Latitude = 21.23,
                Longitude = 24.42,
                ElevationMeters = 300,
                Accessible = true,
                EntryFee = 40.00,
                OpeningHours = "7:00:00",
                //falta la fecha de creacion
            });
    }
    
}