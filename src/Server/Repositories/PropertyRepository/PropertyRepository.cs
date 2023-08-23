using Server.Data;
using Server.Data.Models.Domain;
using Server.Repositories.Interface;

namespace Server.Repositories.Services
{
    /*
     * Repository Design Pattern acts as a middle layer between the rest of application and data access logic.
     * This layer uses only Domain models.
     */
    public class PropertyRepository : IPropertyRepository
    {
        private readonly ApplicationDbContext _context;

        public PropertyRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Property> CreateAsync(Property property)
        {
            await _context.Properties.AddAsync(property);
            await _context.SaveChangesAsync();

            return property;
        }
    }
}
