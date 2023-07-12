using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static Server.Data.Common.Constants.ValidationConstants.Comment;

namespace Server.Data.Models;

public class Post
{
    public Post()
    {
        Id = Guid.NewGuid().ToString();
    }

    [Key]
    public string Id { get; set; }

    [Required]
    [MaxLength(SenderMaxLength)]
    public string? Sender { get; set; } = null!;

    [Required]
    [MaxLength(MassageMax)]
    public string Content { get; set; } = null!;

    [DataType(DataType.Date)]
    public DateTime? CreatedOn { get; set; } = DateTime.Now;

    public DateTime? ModifiedOn { get; set; }

    [Required]
    public bool IsActive { get; set; } = true;

    public DateTime? DeletedOn { get; set; }

    [ForeignKey(nameof(Author))]
    public string AuthorId { get; set; } = null!;
    public virtual ApplicationUser Author { get; set; } = null!;

    public string? PropertyId { get; set; }
    public virtual Property? Property { get; set; }
}