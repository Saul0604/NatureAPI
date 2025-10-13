using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NatureAPI.Models.DTOs;

namespace NatureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrailsController : Controller
    {
        private readonly NatureDbContext _context;

        public TrailsController(NatureDbContext context)
        {
            _context = context;
        }

        // /api/trails/*
        [HttpGet]
        public async Task<ActionResult<List<TrailDto>>> GetAllTrails()
        {
            var trails = await _context.Trails
                .Select(t => new TrailDto
                {
                    Id = t.Id,
                    PlaceId = t.PlaceId,
                    Name = t.Name,
                    DistanceKm = t.DistanceKm,
                    EstimatedTimeMinutes = t.EstimatedTimeMinutes,
                    Difficulty = t.Difficulty,
                    Path = t.Path,
                    IsLoop = t.IsLoop
                })
                .ToListAsync();
            return Ok(trails);
        }
    }
}
