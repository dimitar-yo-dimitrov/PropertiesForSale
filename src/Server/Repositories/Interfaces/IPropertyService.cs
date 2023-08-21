using Server.Data.Models.Domain;

namespace Server.Repositories.Interface
{
    public interface IPropertyService
    {
        Task<Property> CreateAsync(Property property);
    }
}
