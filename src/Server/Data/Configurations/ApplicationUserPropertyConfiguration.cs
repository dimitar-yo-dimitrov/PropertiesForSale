using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Server.Data.Models;

namespace Server.Data.Configuration
{
    public class ApplicationUserPropertyConfiguration : IEntityTypeConfiguration<ApplicationUserProperty>
    {
        public void Configure(EntityTypeBuilder<ApplicationUserProperty> builder)
        {
            builder
                .HasKey(aup => new { aup.ApplicationUserId, aup.PropertyId });
        }
    }
}
