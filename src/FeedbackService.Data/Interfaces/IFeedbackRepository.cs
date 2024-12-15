using FeedbackService.Models.Db;

namespace FeedbackService.Data.Interfaces;

public interface IFeedbackRepository
{
    Task<DbFeedback> GetAsync(Guid id);
    Task CreateAsync(DbFeedback dbFeedback);
    Task UpdateAsync(DbFeedback dbFeedback);
    Task DeleteAsync(Guid id);
}
