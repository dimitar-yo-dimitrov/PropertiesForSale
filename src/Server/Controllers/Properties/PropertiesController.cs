using Microsoft.AspNetCore.Mvc;
using Server.Data.Models.Domain;
using Server.Data.Models.DTO;
using Server.Repositories.Interface;

namespace Server.Controllers.Properties
{
    //[AuthorizeAdministrator]
    public class PropertiesController : ApiController
    {
        private readonly IPropertyRepository _property;

        public PropertiesController(IPropertyRepository property)
        {
            _property = property;
        }

        //[HttpGet]
        //public async Task<IActionResult> GetAllPropertiesAsync()
        //{
        //    var properties = await _property.Properties.ToListAsync();

        //    return Ok(properties);
        //}

        [HttpPost]
        //[Authorize]
        public async Task<IActionResult> AddPropertiesAsync(CreatePropertyRequestDto request)
        {
            //Map DTO to Domain model
            var property = new Property
            {
                Title = request.Title,
                Price = request.Price,
                Description = request.Description,
                Address = request.Address,
                SquareMeters = request.SquareMeters,
                ImageUrl = request.ImageUrl
            };

            await _property.CreateAsync(property);

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
