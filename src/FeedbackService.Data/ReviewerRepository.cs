using FeedbackService.Data.Interfaces;
using FeedbackService.Data.Provider;
using FeedbackService.Models.Db;
using Microsoft.EntityFrameworkCore;

namespace FeedbackService.Data;

public class ReviewerRepository(IDataProvider provider) : IReviewerRepository
{
    public async Task CreateAsync(
        DbReviewer dbReviewer, CancellationToken cancellationToken)
    {
        await provider.Reviewers.AddAsync(dbReviewer, cancellationToken);

        await provider.SaveAsync(cancellationToken);
    }

    public async Task<bool> DeleteAsync(
        Guid id, CancellationToken cancellationToken)
    {
        var dbReviewer = await provider.Reviewers
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        if (dbReviewer is null)
            return false;

        dbReviewer.IsActive = false;

        await provider.SaveAsync(cancellationToken);

        return true;
    }

    public async Task<DbReviewer?> GetAsync(
        Guid id, CancellationToken cancellationToken)
    {
        return await provider.Reviewers
            .AsNoTracking()
            .FirstOrDefaultAsync(r => r.Id == id, cancellationToken);
    }

    public async Task<DbReviewer?> GetWithFeedbackByUserIdAsync(
        Guid userId, CancellationToken cancellationToken)
    {
        return await provider.Reviewers
            .AsNoTracking()
            .Include(r => r.Feedbacks)
            .FirstOrDefaultAsync(r => r.UserId == userId, cancellationToken);
    }

    public async Task<bool> UpdateAsync(
        DbReviewer dbReviewer, CancellationToken cancellationToken)
    {
        await provider.SaveAsync(cancellationToken);

        return true;
    }
}
