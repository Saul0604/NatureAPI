using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NatureAPI.Models.Entities;

namespace NatureAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlaceController : ControllerBase
    {
        private readonly NatureDbContext _context;

        public PlaceController(NatureDbContext context)
        {
            _context = context;
        }

        [HttpPost]
        public async Task<ActionResult> createPlace(
            [FromBody] Place place)
        {
            return Ok();
        }
    }
}
