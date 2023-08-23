using Server.Data.Models.Domain;

namespace Server.Repositories.Interface
{
    public interface IPropertyRepository
    {
        Task<Property> CreateAsync(Property property);
    }
}
