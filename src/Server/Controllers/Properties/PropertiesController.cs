using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Data.Models.Domain;
using Server.Data.Models.DTO;
using Server.Extensions;

namespace Server.Controllers.Properties
{
    [AuthorizeAdministrator]
    public class PropertiesController : ApiController
    {
        private readonly ApplicationDbContext _context;

        public PropertiesController(ApplicationDbContext context)
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
        public async Task<IActionResult> AddPropertiesAsync(CreatePropertyRequestDto request)
        {
            //Map to DTO to Domain model
            var property = new Property
            {
                Title = request.Title,
                Price = request.Price,
                Description = request.Description,
                Address = request.Address,
                SquareMeters = request.SquareMeters,
                ImageUrl = request.ImageUrl
            };

            await _context.Properties.AddAsync(property);
            await _context.SaveChangesAsync();

            //Domain model to DTO
            var response = new PropertyDto
            {
                Id = property.Id,
                Title = property.Title,
                Price = property.Price,
                Description = property.Description,
                Address = property.Address,
                SquareMeters = property.SquareMeters,
                ImageUrl = property.ImageUrl
            };

            return Ok(response);
        }
    }
}
