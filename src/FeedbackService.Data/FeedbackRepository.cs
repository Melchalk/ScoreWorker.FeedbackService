using FeedbackService.Data.Interfaces;
using FeedbackService.Data.Provider;
using FeedbackService.Models.Db;
using Microsoft.EntityFrameworkCore;

namespace FeedbackService.Data;

public class FeedbackRepository(IDataProvider provider) : IFeedbackRepository
{
    public async Task CreateAsync(
        DbFeedback dbFeedback, CancellationToken cancellationToken)
    {
        await provider.Feedbacks.AddAsync(dbFeedback, cancellationToken);

        await provider.SaveAsync(cancellationToken);
    }

    public async Task<bool> DeleteAsync(
        Guid id, CancellationToken cancellationToken)
    {
        var dbFeedback = await provider.Feedbacks
            .FirstOrDefaultAsync(x => x.Id == id, cancellationToken);

        if (dbFeedback is null)
            return false;

        provider.Feedbacks.Remove(dbFeedback);

        await provider.SaveAsync(cancellationToken);

        return true;
    }

    public async Task<bool> SetDismissedUser(
        Guid reviewerId, CancellationToken cancellationToken)
    {
        var reviewer = await provider.Reviewers
            .Include(r => r.Feedbacks)
            .FirstOrDefaultAsync(r => r.Id == reviewerId, cancellationToken);

        if (reviewer is null || reviewer.Feedbacks is null)
            return false;

        foreach(var feedback in reviewer.Feedbacks)
        {
            feedback.IsUserWorking = false;
        }

        await provider.SaveAsync(cancellationToken);

        return true;
    }

    public async Task<DbFeedback?> GetAsync(
        Guid id, CancellationToken cancellationToken)
    {
        return await provider.Feedbacks
            .AsNoTracking()
            .FirstOrDefaultAsync(r => r.Id == id, cancellationToken);
    }

    public async Task<bool> UpdateAsync(
        DbFeedback dbFeedback, CancellationToken cancellationToken)
    {
        await provider.SaveAsync(cancellationToken);

        return true;
    }
}
