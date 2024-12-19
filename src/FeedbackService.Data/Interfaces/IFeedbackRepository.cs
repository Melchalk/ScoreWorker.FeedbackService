using FeedbackService.Models.Db;

namespace FeedbackService.Data.Interfaces;

public interface IFeedbackRepository
{
    Task<DbFeedback?> GetAsync(Guid id, CancellationToken cancellationToken);
    Task<Guid> CreateAsync(DbFeedback dbFeedback, CancellationToken cancellationToken);
    Task<bool> UpdateAsync(DbFeedback dbFeedback, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken);
    Task<bool> SetDismissedUser(Guid reviewerId, CancellationToken cancellationToken);
}
