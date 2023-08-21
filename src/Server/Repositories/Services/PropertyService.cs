using Server.Data.Models.Domain;
using Server.Repositories.Interface;

namespace Server.Repositories.Services
{
    public class PropertyService : IPropertyService
    {
        public Task<Property> CreateAsync(Property property)
        {
            throw new NotImplementedException();
        }
    }
}
