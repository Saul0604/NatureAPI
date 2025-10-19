using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NatureAPI.Models.DTOs;
using NatureAPI.Models.Entities;

namespace NatureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly NatureDbContext _context;

        public PlacesController(NatureDbContext context)
        {
            _context = context;
        }
        //GET all places
        [HttpGet]
        public async Task<IActionResult> GetAllPlaces()
        {
            var places = await _context.Places
                .Include(p => p.Photos)
                .Include(p => p.Trails)
                .ToListAsync();
    
            var result = places.Select(p => new PlaceDto
            {
                Id = p.Id,
                Name = p.Name,
                Description = p.Description,
                Category = p.Category,
                Latitude = p.Latitude,
                Longitude = p.Longitude,
                ElevationMeters = p.ElevationMeters,
                Accessible = p.Accessible,
                EntryFee = p.EntryFee,
                OpeningHours = p.OpeningHours,
                Photos = p.Photos.Select(ph => new PhotoDto
                {
                    Id = ph.Id,
                    PlaceId = ph.PlaceId,
                    Url = ph.Url
                }).ToList(),
                Trails = p.Trails.Select(t => new TrailDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    DistanceKm = t.DistanceKm,
                    EstimatedTimeMinutes = t.EstimatedTimeMinutes,
                    Difficulty = t.Difficulty,
                    Path = t.Path,
                    IsLoop = t.IsLoop
                }).ToList()
            }).ToList();
    
            return Ok(result);
        }
        
        // GET /api/places?category=&difficulty=
        [HttpGet("filter")]
        public async Task<ActionResult<List<Place>>> GetPlacesByCategoryAndDifficulty(
            [FromQuery] string? category,
            [FromQuery] string? difficulty
        )
        {
            var query = _context.Places
                .Include(p => p.Trails)
                .Include(p => p.Photos)
                .Include(p => p.PlaceAmenities)
                .ThenInclude(pa => pa.Amenity)
                .AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(p => p.Category == category);
            }

            if (!string.IsNullOrEmpty(difficulty))
            {
                query = query.Where(p => p.Trails.Any(t => t.Difficulty == difficulty));
            }

            var result = await query
                .Select(p => new PlaceDto
                {
                    Id = p.Id,
                    Name = p.Name,
                    Description = p.Description,
                    Category = p.Category,
                    Latitude = p.Latitude,
                    Longitude = p.Longitude,
                    ElevationMeters = p.ElevationMeters,
                    Accessible = p.Accessible,
                    EntryFee = p.EntryFee,
                    OpeningHours = p.OpeningHours,
                    Trails = p.Trails.Select(t => new TrailDto
                    {
                        Id = t.Id,
                        Name = t.Name,
                        DistanceKm = t.DistanceKm,
                        EstimatedTimeMinutes = t.EstimatedTimeMinutes,
                        Difficulty = t.Difficulty,
                        Path = t.Path,
                        IsLoop = t.IsLoop
                    }).ToList(),
                    Photos = p.Photos.Select(ph => new PhotoDto
                    {
                        Id = ph.Id,
                        PlaceId = ph.PlaceId,
                        Url = ph.Url,
                    }).ToList(),
                    Amenities = p.PlaceAmenities.Select(pa => new AmenityDto
                    {
                        Id = pa.Amenity.Id,
                        Name = pa.Amenity.Name
                    }).ToList()
                })
                .ToListAsync();
            return Ok(result);
        }
        
        // GET /api/places/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Place>> GetPlace(int id)
        {
            var place = await _context.Places
                .Include(p => p.Trails)
                .Include(p => p.Photos)
                .Include(p => p.PlaceAmenities)
                .ThenInclude(pa => pa.Amenity)
                .FirstOrDefaultAsync(p => p.Id == id);

            if (place == null)
                return NotFound();

            var placeDto = new PlaceDto
            {
                Id = place.Id,
                Name = place.Name,
                Description = place.Description,
                Category = place.Category,
                Latitude = place.Latitude,
                Longitude = place.Longitude,
                ElevationMeters = place.ElevationMeters,
                Accessible = place.Accessible,
                EntryFee = place.EntryFee,
                OpeningHours = place.OpeningHours,
                Trails = place.Trails.Select(t => new TrailDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    DistanceKm = t.DistanceKm,
                    EstimatedTimeMinutes = t.EstimatedTimeMinutes,
                    Difficulty = t.Difficulty,
                    Path = t.Path,
                    IsLoop = t.IsLoop
                }).ToList(),
                Photos = place.Photos.Select(ph => new PhotoDto
                {
                    Id = ph.Id,
                    PlaceId = ph.PlaceId,
                    Url = ph.Url
                }).ToList(),
                Amenities = place.PlaceAmenities.Select(pa => new AmenityDto
                {
                    Id = pa.Amenity.Id,
                    Name = pa.Amenity.Name
                }).ToList()
            };
            
            return Ok(placeDto);
        }
        
        // POST /api/places
        [HttpPost]
        public async Task<ActionResult<Place>> CreatePlace(CreatePlaceDto dto)
        {
            // Validar altitud y longitud
            if (dto.Latitude < -90 || dto.Latitude > 90)
                return BadRequest("Latitude must be between -90 and 90.");
            if (dto.Longitude < -180 || dto.Longitude > 180)
                return BadRequest("Longitude must be between -180 and 180.");

            var place = new Place
            {
                Name = dto.Name,
                Description = dto.Description,
                Category = dto.Category,
                Latitude = dto.Latitude,
                Longitude = dto.Longitude,
                ElevationMeters = dto.ElevationMeters,
                Accessible = dto.Accessible,
                EntryFee = dto.EntryFee,
                OpeningHours = dto.OpeningHours,
                CreatedAt = DateTime.Now,
                Trails = dto.Trails?.Select(t => new Trail
                {
                    Name = t.Name,
                    DistanceKm = t.DistanceKm,
                    EstimatedTimeMinutes = t.EstimatedTimeMinutes,
                    Difficulty = t.Difficulty,
                    Path = t.Path,
                    IsLoop = t.IsLoop
                }).ToList(),
                Photos = dto.Photos?.Select(ph => new Photo
                {
                    Url = ph.Url
                }).ToList()
            };

            if (dto.AmenityIds != null)
            {
                place.PlaceAmenities = dto.AmenityIds.Select(id => new PlaceAmenity
                {
                    AmenityId = id
                }).ToList();
            }
            
            _context.Places.Add(place);
            await _context.SaveChangesAsync();
            
            var resultDto = new PlaceDto
            {
                Id = place.Id,
                Name = place.Name,
                Description = place.Description,
                Category = place.Category,
                Latitude = place.Latitude,
                Longitude = place.Longitude,
                ElevationMeters = place.ElevationMeters,
                Accessible = place.Accessible,
                EntryFee = place.EntryFee,
                OpeningHours = place.OpeningHours,
                Trails = place.Trails?.Select(t => new TrailDto
                {
                    Id = t.Id,
                    Name = t.Name,
                    DistanceKm = t.DistanceKm,
                    EstimatedTimeMinutes = t.EstimatedTimeMinutes,
                    Difficulty = t.Difficulty,
                    Path = t.Path,
                    IsLoop = t.IsLoop
                }).ToList(),
                Photos = place.Photos?.Select(ph => new PhotoDto
                {
                    Id = ph.Id,
                    Url = ph.Url
                }).ToList(),
                Amenities = place.PlaceAmenities?.Select(pa => new AmenityDto
                {
                    Id = pa.AmenityId,
                    Name = _context.Amenities.Find(pa.AmenityId)?.Name ?? "Unknown"
                }).ToList()
            };

            return CreatedAtAction(nameof(GetPlace), new { id = place.Id }, resultDto);
        }
    }
}
