using System.ComponentModel.DataAnnotations;

using static Server.Data.Common.Constants.ValidationConstants.Property;

namespace Server.Data.Models.Domain;
public class PropertyType
{
    public PropertyType()
    {
        Properties = new HashSet<Property>();
        Id = Guid.NewGuid().ToString();
    }

    [Key]
    public string Id { get; set; }

    [MaxLength(PropertyMaxTitle)]
    public string Title { get; set; } = null!;

    public virtual ICollection<Property> Properties { get; set; }
}