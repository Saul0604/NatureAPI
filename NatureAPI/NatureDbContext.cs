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
        
        // Seeds de datos Places - DATOS REALES ACTUALIZADOS
        modelBuilder.Entity<Place>().HasData(
            new Place { 
                Id = 1, 
                Name = "Parque Nacional Iztaccíhuatl-Popocatépetl", 
                Description = "Área natural protegida que rodea los volcanes Popocatépetl e Iztaccíhuatl, segunda y tercera montañas más altas de México. Cuenta con bosques de coníferas, praderas alpinas y senderos de alta montaña.", 
                Category = "Parque", 
                Latitude = 19.1791, 
                Longitude = -98.6277, 
                ElevationMeters = 3600, 
                Accessible = true, 
                EntryFee = 45, 
                OpeningHours = "07:00-16:00", 
                CreatedAt = new DateTime(2025, 1, 15, 10, 30, 0) 
            },
            new Place { 
                Id = 2, 
                Name = "Cascada Cola de Caballo", 
                Description = "Impresionante cascada de 25 metros de altura ubicada en el Parque Ecológico Cola de Caballo. El agua cae formando una silueta que asemeja la cola de un caballo.", 
                Category = "Cascada", 
                Latitude = 25.4665, 
                Longitude = -100.1365, 
                ElevationMeters = 620, 
                Accessible = true, 
                EntryFee = 50, 
                OpeningHours = "09:00-17:00", 
                CreatedAt = new DateTime(2025, 1, 15, 10, 30, 0) 
            },
            new Place { 
                Id = 3, 
                Name = "Mirador del Cerro de la Silla", 
                Description = "Icónico cerro de Monterrey con forma de silla de montar. El mirador ofrece vistas panorámicas de toda el área metropolitana. Incluye antiguas instalaciones del teleférico.", 
                Category = "Mirador", 
                Latitude = 25.6303, 
                Longitude = -100.2347, 
                ElevationMeters = 1820, 
                Accessible = true, 
                EntryFee = 0, 
                OpeningHours = "06:00-18:00", 
                CreatedAt = new DateTime(2025, 1, 15, 10, 30, 0) 
            },
            new Place { 
                Id = 4, 
                Name = "Parque Ecológico Chipinque", 
                Description = "Reserva natural privada en la Sierra Madre Oriental con 1,791 hectáreas de bosque. Ofrece más de 60 km de senderos señalizados, miradores y áreas de picnic.", 
                Category = "Parque", 
                Latitude = 25.6187, 
                Longitude = -100.3628, 
                ElevationMeters = 2100, 
                Accessible = true, 
                EntryFee = 90, 
                OpeningHours = "05:30-19:30", 
                CreatedAt = new DateTime(2025, 1, 15, 10, 30, 0) 
            },
            new Place { 
                Id = 5, 
                Name = "Cascada de Basaseachi", 
                Description = "La cascada permanente más alta de México con 246 metros de caída libre. Ubicada en la Sierra Madre Occidental, rodeada de bosques de pino y encino.", 
                Category = "Cascada", 
                Latitude = 28.1917, 
                Longitude = -108.2153, 
                ElevationMeters = 1900, 
                Accessible = false, 
                EntryFee = 35, 
                OpeningHours = "08:00-17:00", 
                CreatedAt = new DateTime(2025, 1, 15, 10, 30, 0) 
            },
            new Place { 
                Id = 6, 
                Name = "Mirador Cerro de la Bufa", 
                Description = "Emblemático cerro de Zacatecas a 2,610 metros sobre el nivel del mar. Sitio histórico de la Toma de Zacatecas y patrimonio de la UNESCO. Ofrece vistas panorámicas de 360 grados.", 
                Category = "Mirador", 
                Latitude = 22.7787, 
                Longitude = -102.5680, 
                ElevationMeters = 2610, 
                Accessible = true, 
                EntryFee = 0, 
                OpeningHours = "09:00-18:00", 
                CreatedAt = new DateTime(2025, 1, 15, 10, 30, 0) 
            },
            new Place { 
                Id = 7, 
                Name = "Parque Nacional Cumbres de Monterrey", 
                Description = "Extenso parque nacional en la Sierra Madre Oriental que abarca 177,395 hectáreas. Incluye cañones profundos, cascadas y rica biodiversidad.", 
                Category = "Parque", 
                Latitude = 25.5833, 
                Longitude = -100.2167, 
                ElevationMeters = 2240, 
                Accessible = true, 
                EntryFee = 0, 
                OpeningHours = "24 horas", 
                CreatedAt = new DateTime(2025, 1, 15, 10, 30, 0) 
            },
            new Place { 
                Id = 8, 
                Name = "Cascada de Piedra Volada", 
                Description = "La cascada más alta de México con 453 metros de caída libre. Ubicada en el mismo parque nacional que Basaseachi, solo lleva agua en temporada de lluvias.", 
                Category = "Cascada", 
                Latitude = 28.1750, 
                Longitude = -108.2083, 
                ElevationMeters = 1850, 
                Accessible = false, 
                EntryFee = 35, 
                OpeningHours = "08:00-17:00", 
                CreatedAt = new DateTime(2025, 1, 15, 10, 30, 0) 
            },
            new Place { 
                Id = 9, 
                Name = "Mirador La Peña de Bernal", 
                Description = "Mirador junto al tercer monolito más grande del mundo. Ubicado en el Pueblo Mágico de Bernal, Querétaro, ofrece vistas espectaculares del valle.", 
                Category = "Mirador", 
                Latitude = 20.7447, 
                Longitude = -99.9444, 
                ElevationMeters = 2500, 
                Accessible = true, 
                EntryFee = 0, 
                OpeningHours = "06:00-19:00", 
                CreatedAt = new DateTime(2025, 1, 15, 10, 30, 0) 
            },
            new Place { 
                Id = 10, 
                Name = "Parque Nacional Nevado de Toluca", 
                Description = "Parque nacional que rodea el volcán Nevado de Toluca (4,680 msnm). Cuenta con dos lagunas cratéricas: Laguna del Sol y Laguna de la Luna.", 
                Category = "Parque", 
                Latitude = 19.1085, 
                Longitude = -99.7573, 
                ElevationMeters = 4200, 
                Accessible = true, 
                EntryFee = 65, 
                OpeningHours = "06:00-17:00", 
                CreatedAt = new DateTime(2025, 1, 15, 10, 30, 0) 
            }
        );
        
        // Seeds de datos Trails - ACTUALIZADOS
        modelBuilder.Entity<Trail>().HasData(
            new Trail{ 
                Id = 1, 
                PlaceId = 1, 
                Name = "Sendero Paso de Cortés", 
                DistanceKm = 8.5, 
                EstimatedTimeMinutes = 240, 
                Difficulty = "Alta", 
                Path = "[[19.1791, -98.6277], [19.1850, -98.6200], [19.1900, -98.6150]]", 
                IsLoop = false
            },
            new Trail{ 
                Id = 2, 
                PlaceId = 1, 
                Name = "Mirador La Joya", 
                DistanceKm = 3.5, 
                EstimatedTimeMinutes = 90, 
                Difficulty = "Media", 
                Path = "[[19.1750, -98.6300], [19.1780, -98.6250], [19.1800, -98.6220]]", 
                IsLoop = false
            },
            new Trail{ 
                Id = 3, 
                PlaceId = 2, 
                Name = "Sendero a la Cascada", 
                DistanceKm = 0.6, 
                EstimatedTimeMinutes = 30, 
                Difficulty = "Baja", 
                Path = "[[25.4700, -100.1400], [25.4680, -100.1380], [25.4665, -100.1365]]", 
                IsLoop = false
            },
            new Trail{ 
                Id = 4, 
                PlaceId = 3, 
                Name = "Ascenso Pico Antena", 
                DistanceKm = 4.3, 
                EstimatedTimeMinutes = 150, 
                Difficulty = "Media", 
                Path = "[[25.6200, -100.2400], [25.6250, -100.2370], [25.6303, -100.2347]]", 
                IsLoop = false
            },
            new Trail{ 
                Id = 5, 
                PlaceId = 4, 
                Name = "Sendero del Coatí", 
                DistanceKm = 5.8, 
                EstimatedTimeMinutes = 120, 
                Difficulty = "Media", 
                Path = "[[25.6150, -100.3650], [25.6200, -100.3600], [25.6250, -100.3580], [25.6150, -100.3650]]", 
                IsLoop = true
            },
            new Trail{ 
                Id = 6, 
                PlaceId = 5, 
                Name = "Descenso a la Base de la Cascada", 
                DistanceKm = 2.0, 
                EstimatedTimeMinutes = 90, 
                Difficulty = "Alta", 
                Path = "[[28.1950, -108.2180], [28.1930, -108.2165], [28.1917, -108.2153]]", 
                IsLoop = false
            },
            new Trail{ 
                Id = 7, 
                PlaceId = 6, 
                Name = "Ruta Histórica La Bufa", 
                DistanceKm = 2.5, 
                EstimatedTimeMinutes = 60, 
                Difficulty = "Media", 
                Path = "[[22.7720, -102.5720], [22.7750, -102.5700], [22.7787, -102.5680]]", 
                IsLoop = false
            },
            new Trail{ 
                Id = 8, 
                PlaceId = 7, 
                Name = "Sendero Cañón de la Huasteca", 
                DistanceKm = 4.2, 
                EstimatedTimeMinutes = 110, 
                Difficulty = "Media", 
                Path = "[[25.5900, -100.2200], [25.5850, -100.2150], [25.5800, -100.2100]]", 
                IsLoop = false
            },
            new Trail{ 
                Id = 9, 
                PlaceId = 8, 
                Name = "Mirador Piedra Volada", 
                DistanceKm = 3.8, 
                EstimatedTimeMinutes = 140, 
                Difficulty = "Alta", 
                Path = "[[28.1800, -108.2120], [28.1770, -108.2100], [28.1750, -108.2083]]", 
                IsLoop = false
            },
            new Trail{ 
                Id = 10, 
                PlaceId = 9, 
                Name = "Ascenso a la Peña", 
                DistanceKm = 1.5, 
                EstimatedTimeMinutes = 90, 
                Difficulty = "Media", 
                Path = "[[20.7400, -99.9480], [20.7420, -99.9460], [20.7447, -99.9444]]", 
                IsLoop = false
            }
        );
        
        // Seed de Photos - URLs REALES
        modelBuilder.Entity<Photo>().HasData(
            new Photo{ Id = 1, PlaceId = 1, Url = "https://www.gob.mx/cms/uploads/article/main_image/27513/blog_izta_popo.jpg"},
            new Photo{ Id = 2, PlaceId = 2, Url = "https://escapadas.mexicodesconocido.com.mx/wp-content/uploads/2020/10/Cascada-Cola-de-Caballo-XL-scaled.jpeg"},
            new Photo{ Id = 3, PlaceId = 3, Url = "https://www.civitatis.com/f/mexico/monterrey/galeria/senderismo-cerro-silla4.jpg"},
            new Photo{ Id = 4, PlaceId = 4, Url = "https://visitmexico.com/media/usercontent/6886d984e4344-chipinque-3_gmxdot_jpg"},
            new Photo{ Id = 5, PlaceId = 5, Url = "https://www.gob.mx/cms/uploads/image/file/247330/Basaseachi__foto_Teresita_Lasso__18_.JPG"},
            new Photo{ Id = 6, PlaceId = 6, Url = "https://www.zacatecastravel.com/img/lugares/miradorlabufa_grande.jpg"},
            new Photo{ Id = 7, PlaceId = 7, Url = "https://www.gob.mx/cms/uploads/article/main_image/28051/blog_PNCM.jpg"},
            new Photo{ Id = 8, PlaceId = 8, Url = "https://noro.mx/wp-content/uploads/2024/08/Cascada-Piedra-Volada-renace-en-la-Sierra-Tarahumara.jpg"},
            new Photo{ Id = 9, PlaceId = 9, Url = "https://upload.wikimedia.org/wikipedia/commons/thumb/9/99/Mirador_de_la_Pe%C3%B1a.jpg/1200px-Mirador_de_la_Pe%C3%B1a.jpg"},
            new Photo{ Id = 10, PlaceId = 10, Url = "https://cdn.mexicodestinos.com/lugares/nevado-de-toluca-galeria.jpg"}
        );
        
        // Seed de Amenities
        modelBuilder.Entity<Amenity>().HasData(
            new Amenity{ Id = 1, Name = "Baños" },
            new Amenity{ Id = 2, Name = "Estacionamiento" },
            new Amenity{ Id = 3, Name = "Mirador" },
            new Amenity{ Id = 4, Name = "Zona de Picnic" },
            new Amenity{ Id = 5, Name = "Área de Camping" },
            new Amenity{ Id = 6, Name = "Señalización" },
            new Amenity{ Id = 7, Name = "Sendero Guiado" },
            new Amenity{ Id = 8, Name = "Restaurante" },
            new Amenity{ Id = 9, Name = "Área de Observación" },
            new Amenity{ Id = 10, Name = "Centro de Visitantes" }
        );
        
        // Seed de PlaceAmenities
        modelBuilder.Entity<PlaceAmenity>().HasData(
            new PlaceAmenity{ PlaceId = 1, AmenityId = 1 },
            new PlaceAmenity{ PlaceId = 1, AmenityId = 2 },
            new PlaceAmenity{ PlaceId = 1, AmenityId = 4 },
            new PlaceAmenity{ PlaceId = 1, AmenityId = 10 },
            new PlaceAmenity{ PlaceId = 2, AmenityId = 1 },
            new PlaceAmenity{ PlaceId = 2, AmenityId = 2 },
            new PlaceAmenity{ PlaceId = 2, AmenityId = 4 },
            new PlaceAmenity{ PlaceId = 2, AmenityId = 8 },
            new PlaceAmenity{ PlaceId = 3, AmenityId = 3 },
            new PlaceAmenity{ PlaceId = 3, AmenityId = 6 },
            new PlaceAmenity{ PlaceId = 4, AmenityId = 1 },
            new PlaceAmenity{ PlaceId = 4, AmenityId = 2 },
            new PlaceAmenity{ PlaceId = 4, AmenityId = 3 },
            new PlaceAmenity{ PlaceId = 4, AmenityId = 6 },
            new PlaceAmenity{ PlaceId = 4, AmenityId = 8 },
            new PlaceAmenity{ PlaceId = 5, AmenityId = 2 },
            new PlaceAmenity{ PlaceId = 5, AmenityId = 3 },
            new PlaceAmenity{ PlaceId = 5, AmenityId = 5 },
            new PlaceAmenity{ PlaceId = 6, AmenityId = 3 },
            new PlaceAmenity{ PlaceId = 6, AmenityId = 8 },
            new PlaceAmenity{ PlaceId = 7, AmenityId = 1 },
            new PlaceAmenity{ PlaceId = 7, AmenityId = 5 },
            new PlaceAmenity{ PlaceId = 7, AmenityId = 6 },
            new PlaceAmenity{ PlaceId = 8, AmenityId = 3 },
            new PlaceAmenity{ PlaceId = 9, AmenityId = 3 },
            new PlaceAmenity{ PlaceId = 9, AmenityId = 8 },
            new PlaceAmenity{ PlaceId = 10, AmenityId = 2 },
            new PlaceAmenity{ PlaceId = 10, AmenityId = 3 },
            new PlaceAmenity{ PlaceId = 10, AmenityId = 10 }
        );
    }
}