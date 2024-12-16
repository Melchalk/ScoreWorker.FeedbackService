using FeedbackService.Models.Db;

namespace FeedbackService.Data.Interfaces;

public interface IFeedbackRepository
{
    Task<DbFeedback?> GetAsync(Guid id, CancellationToken cancellationToken);
    Task CreateAsync(DbFeedback dbFeedback, CancellationToken cancellationToken);
    Task<bool> UpdateAsync(DbFeedback dbFeedback, CancellationToken cancellationToken);
    Task<bool> DeleteAsync(Guid id, CancellationToken cancellationToken);
}
