using System.ComponentModel.DataAnnotations;

namespace Shared;

public class Post
{
    [Required]
    public string Title { get; set; }
    [MinLength(10)]
    public string Content { get; set; }
}
