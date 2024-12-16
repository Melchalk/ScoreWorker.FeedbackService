using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations;

namespace FeedbackService.Models.Db;

public class DbFeedback
{
    public const string TableName = "Feedbacks";

    [Key]
    public Guid Id { get; set; }
    public Guid ReviewerId { get; set; }
    public Guid UnderReviewId { get; set; }
    public required string Review { get; set; }
    public bool IsUserWorking { get; set; }
    public DateTime CreatedAt { get; set; }

    public DbReviewer? Reviewer { get; set; }
}

public class DbFeedbackConfiguration : IEntityTypeConfiguration<DbFeedback>
{
    public void Configure(EntityTypeBuilder<DbFeedback> builder)
    {
        builder.ToTable(DbFeedback.TableName);

        builder.HasOne(f => f.Reviewer)
            .WithMany(r => r.Feedbacks)
            .HasForeignKey(f => f.ReviewerId);
    }
}