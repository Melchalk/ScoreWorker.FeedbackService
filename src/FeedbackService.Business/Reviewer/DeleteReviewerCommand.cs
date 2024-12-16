using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Reviewer;

public class DeleteReviewerCommand(IReviewerRepository repository) : IDeleteReviewerCommand
{
    public Task<ResponseInfo<bool>> ExecuteAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
