using FeedbackService.Models.Db;

namespace FeedbackService.Data.Interfaces;

public interface IReviewerRepository
{
    Task<DbReviewer> GetAsync(Guid id);
    Task CreateAsync(DbReviewer dbReviewer);
    Task UpdateAsync(DbReviewer dbReviewer);
    Task DeleteAsync(Guid id);
}
