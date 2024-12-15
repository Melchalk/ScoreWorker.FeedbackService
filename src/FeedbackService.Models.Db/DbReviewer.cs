using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace FeedbackService.Models.Db;

public class DbReviewer
{
    public const string TableName = "ScoreCriterias";

    [Key]
    public Guid Id { get; set; }
    public Guid UserId { get; set; }


    public List<DbFeedback>? Feedbacks { get; set; }
}

public class DbReviewerConfiguration : IEntityTypeConfiguration<DbReviewer>
{
    public void Configure(EntityTypeBuilder<DbReviewer> builder)
    {
        builder.ToTable(DbReviewer.TableName);

        builder.HasMany(r => r.Feedbacks)
            .WithOne(f => f.Reviewer)
            .HasForeignKey(f => f.ReviewerId);
    }
}