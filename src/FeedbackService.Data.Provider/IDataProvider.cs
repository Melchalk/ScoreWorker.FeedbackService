using FeedbackService.Models.Db;
using Microsoft.EntityFrameworkCore;

namespace FeedbackService.Data.Provider;

/// <feedback>
/// Data provider with DbSets of the app.
/// </feedback>
public interface IDataProvider : IBaseDataProvider
{
    DbSet<DbReview> Review { get; set; }
    DbSet<DbReviewer> Reviewer { get; set; }
}