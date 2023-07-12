using Microsoft.EntityFrameworkCore;
using Server.Data.Models;

namespace Server.Data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseLazyLoadingProxies();
    }

    public virtual DbSet<ApplicationUserProperty> ApplicationUserProperties { get; set; } = null!;

    public virtual DbSet<City> Cities { get; init; } = null!;

    public virtual DbSet<Post> Posts { get; init; } = null!;

    public virtual DbSet<Property> Properties { get; init; } = null!;

    public virtual DbSet<PropertyType> PropertyTypes { get; init; } = null!;
}