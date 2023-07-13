using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Data.Models;

namespace Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PropertyController : Controller
    {
        private readonly ApplicationDbContext _context;

        public PropertyController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllPropertiesAsync()
        {
            var properties = await _context.Properties.ToListAsync();

            return Ok(properties);
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddPropertiesAsync([FromBody] Property propertyRequest)
        {
            propertyRequest.Id = Guid.NewGuid().ToString();

            await _context.Properties.AddAsync(propertyRequest);
            await _context.SaveChangesAsync();

            return Ok(propertyRequest);
        }
    }
}
