using FeedbackService.Models.Db;

namespace FeedbackService.Data.Interfaces;

public interface IReviewerRepository
{
    Task<DbReviewer?> GetAsync(Guid id, CancellationToken cancellationToken);
    Task<DbReviewer?> GetWithFeedbackByUserIdAsync(Guid userId, CancellationToken cancellationToken);
    Task CreateAsync(DbReviewer dbReviewer, CancellationToken cancellationToken);
    Task<bool> UpdateAsync(DbReviewer dbReviewer, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken);
}
