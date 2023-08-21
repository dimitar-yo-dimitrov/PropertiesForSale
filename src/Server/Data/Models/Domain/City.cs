using System.ComponentModel.DataAnnotations;

using static Server.Data.Common.Constants.ValidationConstants.City;

namespace Server.Data.Models.Domain;

public class City
{
    public City()
    {
        Id = Guid.NewGuid().ToString();
    }

    [Key]
    public string Id { get; set; }

    [MaxLength(CityMaxName)]
    public string Name { get; set; } = null!;
}