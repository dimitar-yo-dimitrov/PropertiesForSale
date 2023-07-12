using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

using static Server.Data.Common.Constants.ValidationConstants.Property;
using static Server.Data.Common.Constants.ValidationConstants.User;

namespace Server.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        public ApplicationUser()
        {
            Id = Guid.NewGuid().ToString();
            ApplicationUserProperties = new HashSet<ApplicationUserProperty>();
            Posts = new HashSet<Post>();
        }

        [StringLength(UserFirstNameMaxLength)]
        public string? FirstName { get; set; } = null!;

        [StringLength(UserLastNameMaxLength)]
        public string? LastName { get; set; } = null!;

        [MaxLength(MaxUrl)]
        [Url]
        public string? ProfilePicture { get; set; }

        public DateTime? CreatedOn { get; set; } = DateTime.Now;

        public DateTime? ModifiedOn { get; set; }

        public bool IsActive { get; set; } = true;

        public DateTime? DeletedOn { get; set; }

        public virtual ICollection<ApplicationUserProperty> ApplicationUserProperties { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }
}
