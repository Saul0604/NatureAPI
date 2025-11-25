using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NatureAPI.Models.DTOs;
using NatureAPI.Models.Entities;
using OpenAI.Chat;
using System.Net;


namespace NatureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlacesController : ControllerBase
    {
        private readonly NatureDbContext _context;
        private readonly IConfiguration _config;

        public PlacesController(NatureDbContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
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
        [HttpGet("prueba deploy")]

        [HttpGet("ai-analyze")]
        public async Task<IActionResult> AnalyzePlacesWithAI([FromQuery] int? placeId)
        {
            var openAIKey = _config["OpenAIKey"];
            if (string.IsNullOrWhiteSpace(openAIKey))
            {
                return StatusCode((int)HttpStatusCode.InternalServerError,
                    "OpenAIKey is not configured. Set it in appsettings, environment variables, or user-secrets.");
            }

            try
            {
                // PRIMERO SE OBTIENEN LOS DATOS - Si viene placeId, filtrar por ese lugar
                var query = _context.Places
                    .Include(p => p.Trails)
                    .Include(p => p.Photos)
                    .Include(p => p.PlaceAmenities)
                    .ThenInclude(pa => pa.Amenity)
                    .Include(p => p.Reviews)
                    .AsQueryable();

                // Si se proporciona un placeId, filtrar solo ese lugar
                if (placeId.HasValue)
                {
                    query = query.Where(p => p.Id == placeId.Value);
                }

                var places = await query.ToListAsync();

                if (!places.Any())
                {
                    return NotFound("No se encontró el lugar especificado.");
                }

                // SE PREPARAN LOS DATOS EN FORMATO JSON
                var placesData = places.Select(p => new
                {
                     p.Id,
                    p.Name,
                    p.Description,
                    p.Latitude,
                    p.Longitude,
                    p.Category,
                    p.ElevationMeters,
                    Trails = p.Trails.Select(t => new { t.Name, t.Difficulty, t.DistanceKm }).ToList(),
                    Reviews = p.Reviews.Select(r => new { r.Rating, r.Comment }).ToList()
                }).ToList();

                var jsonData = System.Text.Json.JsonSerializer.Serialize(placesData);

                // SE HACE EL PROMPT CON LOS DATOS - usar el prompt apropiado según el caso
                string prompt;
                if (placeId.HasValue)
                {
                    // Usar el prompt específico para un solo lugar
                    prompt = Prompts.GenerateDataForSinglePlace(jsonData);
                }
                else
                {
                    // Usar el prompt original para todos los lugares
                    prompt = Prompts.GenerateData(jsonData);
                }

                // LA IA ANALIZA LOS DATOS
                var client = new ChatClient(
                    model: "gpt-4o-mini",
                    apiKey: openAIKey);

                var result = await client.CompleteChatAsync(
                    new UserChatMessage(prompt));

                // SE DA UNA RESPUESTA CON LOS DATOS DE LA IA
                var aiResponse = result?.Value?.Content?.FirstOrDefault()?.Text ?? string.Empty;
                
                // Limpiar la respuesta de markdown si lo incluye
                var cleanResponse = aiResponse.Trim();
                if (cleanResponse.StartsWith("```json"))
                {
                    cleanResponse = cleanResponse.Substring(7); // Remove ```json
                }
                if (cleanResponse.StartsWith("```"))
                {
                    cleanResponse = cleanResponse.Substring(3); // Remove ```
                }
                if (cleanResponse.EndsWith("```"))
                {
                    cleanResponse = cleanResponse.Substring(0, cleanResponse.Length - 3); // Remove trailing ```
                }
                cleanResponse = cleanResponse.Trim();

                // Intentar parsear el JSON para devolverlo estructurado
                try
                {
                    var parsedResponse = System.Text.Json.JsonSerializer.Deserialize<object>(cleanResponse);
                    return Ok(parsedResponse);
                }
                catch
                {
                    // Si falla el parseo, devolver la respuesta limpia como texto
                    return Ok(new { response = cleanResponse, note = "Response could not be parsed as JSON" });
                }
            }
            catch (Exception ex)
            {
                // Do not return secrets; return the message and suggest checking the key/connection.
                return StatusCode((int)HttpStatusCode.InternalServerError,
                    $"Error calling OpenAI API: {ex.Message}. Ensure OpenAIKey is correct and the host has internet access.");
            }
        }

     }
 }
