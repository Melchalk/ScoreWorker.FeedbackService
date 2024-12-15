using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Models.Dto.Requests.Reviewer;
using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Reviewer;

public class UpdateReviewerCommand : IUpdateReviewerCommand
{
    public Task<ResponseInfo<bool>> ExecuteAsync(
        UpdateReviewerRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
