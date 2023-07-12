using System.ComponentModel.DataAnnotations;
using static Server.Data.Common.Constants.ValidationConstants.City;

namespace Server.Data.Models;

public class City
{

    [Key]
    public string Id { get; set; } = null!;

    [MaxLength(CityMaxName)]
    public string Name { get; set; } = null!;
}