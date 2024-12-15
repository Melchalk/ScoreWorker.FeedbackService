using FeedbackService.Data.Interfaces;
using FeedbackService.Data.Provider;
using FeedbackService.Models.Db;

namespace FeedbackService.Data;

public class ReviewerRepository(IDataProvider provider) : IReviewerRepository
{
    public Task CreateAsync(DbReviewer dbReviewer)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<DbReviewer> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(DbReviewer dbReviewer)
    {
        throw new NotImplementedException();
    }
}
