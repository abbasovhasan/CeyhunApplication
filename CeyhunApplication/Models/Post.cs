﻿namespace CeyhunApplication.Models;

public class Post : BaseEntity
{
    public string Title { get; set; } = null!;
    public string Content { get; set; } = null!;
    public string? ImageUrl { get; set; }
    public DateTime PublishDate { get; set; }

    public int CategoryId { get; set; }
    public Category? Category { get; set; } = null!;

    public virtual ICollection<PopularTagPost>? PostPopularTags { get; set; }
}
