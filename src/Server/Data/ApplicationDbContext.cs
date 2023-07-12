using Microsoft.EntityFrameworkCore;
using Server.Data.Configuration;
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

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
        modelBuilder.ApplyConfiguration(new ApplicationUserPropertyConfiguration());
        // modelBuilder.ApplyConfiguration(new PropertyTypesConfiguration());
        // modelBuilder.ApplyConfiguration(new CitiesConfiguration());
        // modelBuilder.ApplyConfiguration(new PostConfiguration());

        var entityTypes = modelBuilder.Model.GetEntityTypes().ToList();

        // Disable cascade delete
        var foreignKeys = entityTypes
            .SelectMany(e => e.GetForeignKeys().Where(f => f.DeleteBehavior == DeleteBehavior.Cascade));
        foreach (var foreignKey in foreignKeys)
        {
            foreignKey.DeleteBehavior = DeleteBehavior.Restrict;
        }

        base.OnModelCreating(modelBuilder);
    }

    public virtual DbSet<ApplicationUserProperty> ApplicationUserProperties { get; set; } = null!;

    public virtual DbSet<City> Cities { get; init; } = null!;

    public virtual DbSet<Post> Posts { get; init; } = null!;

    public virtual DbSet<Property> Properties { get; init; } = null!;

    public virtual DbSet<PropertyType> PropertyTypes { get; init; } = null!;
}