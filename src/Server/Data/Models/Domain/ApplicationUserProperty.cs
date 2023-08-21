using System.ComponentModel.DataAnnotations.Schema;

namespace Server.Data.Models.Domain;

public class ApplicationUserProperty
{
    public ApplicationUserProperty()
    {
        ApplicationUserId = Guid.NewGuid().ToString();
        PropertyId = Guid.NewGuid().ToString();
    }

    [ForeignKey(nameof(ApplicationUser))]
    public string ApplicationUserId { get; set; }
    public virtual ApplicationUser ApplicationUser { get; set; } = null!;

    [ForeignKey(nameof(Property))]
    public string PropertyId { get; set; }
    public virtual Property Property { get; set; } = null!;
}