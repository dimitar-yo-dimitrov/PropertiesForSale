﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using static Server.Data.Common.Constants.ValidationConstants.Property;

namespace Server.Data.Models;

public class Property
{
    public Property()
    {
        Id = Guid.NewGuid().ToString();
        ApplicationUserProperties = new HashSet<ApplicationUserProperty>();
        Posts = new HashSet<Post>();
    }

    [Key]
    public string Id { get; set; }

    [Required]
    [MaxLength(PropertyMaxTitle)]
    public string Title { get; set; } = null!;

    [Required]
    [Precision(18, 2)]
    public decimal Price { get; set; }

    [MaxLength(PropertyMaxDescription)]
    public string Description { get; set; } = null!;

    [Required]
    [MaxLength(HomeMaxAddress)]
    public string Address { get; set; } = null!;

    public double? SquareMeters { get; set; }

    [Required(AllowEmptyStrings = false)]
    [MaxLength(MaxUrl)]
    [Url]
    public string ImageUrl { get; set; } = null!;

    public bool IsActive { set; get; } = true;
    public DateTime? DeletedOn { get; set; }

    // Navigational properties
    [ForeignKey(nameof(PropertyType))]
    public string PropertyTypeId { get; set; } = null!;

    public virtual PropertyType PropertyType { get; set; } = null!;

    // Navigational properties
    [ForeignKey(nameof(City))]
    public string CityId { get; set; } = null!;

    public virtual City City { get; set; } = null!;

    // Navigational properties
    [ForeignKey(nameof(Owner))]
    public string OwnerId { get; set; } = null!;
    public virtual ApplicationUser Owner { get; set; } = null!;

    public virtual ICollection<ApplicationUserProperty> ApplicationUserProperties { get; set; }

    public virtual ICollection<Post> Posts { get; set; }
}