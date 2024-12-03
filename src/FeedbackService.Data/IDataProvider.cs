using FeedbackService.Models.Db;
using Microsoft.EntityFrameworkCore;

namespace FeedbackService.Data;

/// <summary>
/// Data provider with DbSets of the app.
/// </summary>
public interface IDataProvider : IBaseDataProvider
{
    DbSet<DbReview> Review { get; set; }
    DbSet<DbReviewer> Reviewer { get; set; }
}