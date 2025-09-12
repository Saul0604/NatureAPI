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
        
        // Seeds de datos Places
        modelBuilder.Entity<Place>().HasData(
            new Place { Id = 1, Name = "Parque Nacional Iztaccíhuatl", Description = "Parque con senderos y miradores", Category = "Parque", Latitude = 19.2200, Longitude = -98.6570, ElevationMeters = 3900, Accessible = true, EntryFee = 50, OpeningHours = "08:00-18:00", CreatedAt = new DateTime(2025, 9, 12, 3, 52, 0) },
            new Place { Id = 2, Name = "Cascada Cola de Caballo", Description = "Cascada famosa en Nuevo León", Category = "Cascada", Latitude = 25.123, Longitude = -99.123, ElevationMeters = 50, Accessible = true, EntryFee = 0, OpeningHours = "08:00-17:00", CreatedAt = new DateTime(2025, 9, 12, 3, 52, 0) },
            new Place { Id = 3, Name = "Mirador del Cerro de la Silla", Description = "Mirador icónico en Monterrey", Category = "Mirador", Latitude = 25.675, Longitude = -100.309, ElevationMeters = 1800, Accessible = true, EntryFee = 0, OpeningHours = "06:00-20:00", CreatedAt = new DateTime(2025, 9, 12, 3, 52, 0) },
            new Place { Id = 4, Name = "Parque Ecológico Chipinque", Description = "Parque natural con senderos", Category = "Parque", Latitude = 25.678, Longitude = -100.234, ElevationMeters = 2000, Accessible = true, EntryFee = 20, OpeningHours = "07:00-19:00", CreatedAt = new DateTime(2025, 9, 12, 3, 52, 0) },
            new Place { Id = 5, Name = "Cascada de Basaseacic", Description = "Cascada más alta de Chihuahua", Category = "Cascada", Latitude = 27.082, Longitude = -107.867, ElevationMeters = 1800, Accessible = false, EntryFee = 30, OpeningHours = "08:00-17:00", CreatedAt = new DateTime(2025, 9, 12, 3, 52, 0) },
            new Place { Id = 6, Name = "Mirador La Bufa", Description = "Mirador panorámico en Zacatecas", Category = "Mirador", Latitude = 22.771, Longitude = -102.583, ElevationMeters = 2500, Accessible = true, EntryFee = 10, OpeningHours = "06:00-20:00", CreatedAt = new DateTime(2025, 9, 12, 3, 52, 0) },
            new Place { Id = 7, Name = "Parque Nacional Cumbres de Monterrey", Description = "Parque con diversas rutas de senderismo", Category = "Parque", Latitude = 25.410, Longitude = -100.247, ElevationMeters = 2600, Accessible = true, EntryFee = 40, OpeningHours = "07:00-18:00", CreatedAt = new DateTime(2025, 9, 12, 3, 52, 0) },
            new Place { Id = 8, Name = "Cascada de Piedra Volada", Description = "Cascada en el cañón de Chihuahua", Category = "Cascada", Latitude = 27.037, Longitude = -98.6570, ElevationMeters = 1700, Accessible = false, EntryFee = 25, OpeningHours = "08:00-17:00", CreatedAt = new DateTime(2025, 9, 12, 3, 52, 0) },
            new Place { Id = 9, Name = "Mirador de la Peña", Description = "Mirador en Bernal, Queretáro", Category = "Mirador", Latitude = 20.667, Longitude = -100.123, ElevationMeters = 2100, Accessible = true, EntryFee = 15, OpeningHours = "06:00-19:00", CreatedAt = new DateTime(2025, 9, 12, 3, 52, 0) },
            new Place { Id = 10, Name = "Parque Nacional Nevado de Toluca", Description = "Parque con montaña y lagunas", Category = "Parque", Latitude = 19.118, Longitude = -99.767, ElevationMeters = 4600, Accessible = true, EntryFee = 50, OpeningHours = "07:00-18:00", CreatedAt = new DateTime(2025, 9, 12, 3, 52, 0) }
        );
    }
}