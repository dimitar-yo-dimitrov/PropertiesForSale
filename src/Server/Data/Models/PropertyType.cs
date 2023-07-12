using System.ComponentModel.DataAnnotations;

using static Server.Data.Common.Constants.ValidationConstants.Property;

namespace Server.Data.Models;
public class PropertyType
{
    public PropertyType()
    {
        Properties = new HashSet<Property>();
    }

    [Key]
    public string Id { get; set; } = null!;

    [MaxLength(PropertyMaxTitle)]
    public string Title { get; set; } = null!;

    public virtual ICollection<Property> Properties { get; set; }
}