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
        
        // Seeds de datos Trails
        modelBuilder.Entity<Trail>().HasData(
            new Trail{ Id = 1, PlaceId = 1, Name = "Sendero Volcán", DistanceKm = 5.0, EstimatedTimeMinutes = 180, Difficulty = "Media", Path = "[[19.2200, -98.6570], [19.2220, -98.6630], [19.2200, -98.6570]]", IsLoop = true},
            new Trail{ Id = 2, PlaceId = 1, Name = "Mirador Principal", DistanceKm = 2.0, EstimatedTimeMinutes = 60, Difficulty = "Baja", Path = "[[25.1230, -99.1230], [25.1240, -99.1245], [25.1255, -99.1260]]", IsLoop = false},
            new Trail{ Id = 3, PlaceId = 2, Name = "Camino Cascada", DistanceKm = 1.5, EstimatedTimeMinutes = 40, Difficulty = "Baja", Path = "[[25.6750, -100.3090], [25.6765, -100.3075], [25.6780, -100.3060]]", IsLoop = false},
            new Trail{ Id = 4, PlaceId = 3, Name = "Subida Mirador", DistanceKm = 1.2, EstimatedTimeMinutes = 45, Difficulty = "Media", Path = "[[25.6780, -100.2340], [25.6800, -100.2330], [25.6815, -100.2320], [25.6780, -100.2340]]", IsLoop = true},
            new Trail{ Id = 5, PlaceId = 4, Name = "Circuito Chipinque", DistanceKm = 3.5, EstimatedTimeMinutes = 90, Difficulty = "Media", Path = "[[27.0820, -107.8670], [27.0835, -107.8650], [27.0850, -107.8630]]", IsLoop = true},
            new Trail{ Id = 6, PlaceId = 5, Name = "Caminata Basaseachic", DistanceKm = 2.5, EstimatedTimeMinutes = 80, Difficulty = "Alta", Path = "[[22.7710, -102.5830], [22.7715, -102.5820], [22.7720, -102.5810]]", IsLoop = false},
            new Trail{ Id = 7, PlaceId = 6, Name = "Ruta La Bufa", DistanceKm = 1.0, EstimatedTimeMinutes = 30, Difficulty = "Baja", Path = "[[25.4100, -100.2470], [25.4120, -100.2455], [25.4150, -100.2440], [25.4100, -100.2470]]", IsLoop = false},
            new Trail{ Id = 8, PlaceId = 7, Name = "Sendero Monterrey", DistanceKm = 6.0, EstimatedTimeMinutes = 200, Difficulty = "Alta", Path = "[[27.0370, -98.6570], [27.0385, -98.6555], [27.0400, -98.6540]]", IsLoop = true},
            new Trail{ Id = 9, PlaceId = 8, Name = "Camino Piedra Volada", DistanceKm = 3.0, EstimatedTimeMinutes = 100, Difficulty = "Media", Path = "[[20.6670, -100.1230], [20.6685, -100.1215], [20.6700, -100.1200]]", IsLoop = false},
            new Trail{ Id = 10, PlaceId = 9, Name = "Subida Peña", DistanceKm = 1.8, EstimatedTimeMinutes = 50, Difficulty = "Media", Path = "[[19.1180, -99.7670], [19.1200, -99.7650], [19.1220, -99.7630], [19.1180, -99.7670]]", IsLoop = true}
        );
        
        // Seed de Photos
        modelBuilder.Entity<Photo>().HasData(
            new Photo{ Id = 1, PlaceId = 1, Url = "https://www.gob.mx/cms/uploads/article/main_image/27513/blog_izta_popo.jpg"},
            new Photo{ Id = 2, PlaceId = 2, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTRN5dNWqAwUhFHJpo0EaIQdx_tsnLG-FrjaQ&s"},
            new Photo{ Id = 3, PlaceId = 3, Url = "https://imggraficos.gruporeforma.com/2023/06/2-2.jpg"},
            new Photo{ Id = 4, PlaceId = 4, Url = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRI_2vrL7aIS0K2cWYlFutIDKF31_RjAhifOg&s"},
            new Photo{ Id = 5, PlaceId = 5, Url = "https://i0.wp.com/foodandpleasure.com/wp-content/uploads/2024/12/cascada-de-basaseachi1.jpg?fit=1500%2C1610&ssl=1"},
            new Photo{ Id = 6, PlaceId = 6, Url = "https://offloadmedia.feverup.com/guadalajarasecreta.com/wp-content/uploads/2022/10/07033934/cerro-de-la-bufa.jpg"},
            new Photo{ Id = 7, PlaceId = 7, Url = "https://www.gob.mx/cms/uploads/article/main_image/28051/blog_PNCM.jpg"},
            new Photo{ Id = 8, PlaceId = 8, Url = "https://www.mexicodesconocido.com.mx/sites/default/files/nodes/1024/piedra-volada.jpg"},
            new Photo{ Id = 9, PlaceId = 9, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Mirador_de_la_Pe%C3%B1a.jpg/1200px-Mirador_de_la_Pe%C3%B1a.jpg"},
            new Photo{ Id = 10, PlaceId = 10, Url = "https://a.travel-assets.com/findyours-php/viewfinder/images/res70/201000/201283-Nevado-De-Toluca-National-Park.jpg"}
        );
    }
}