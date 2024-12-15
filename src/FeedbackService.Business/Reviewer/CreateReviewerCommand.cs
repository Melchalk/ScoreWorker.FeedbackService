using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Models.Dto.Requests.Reviewer;
using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Reviewer;

public class CreateReviewerCommand : ICreateReviewerCommand
{
    public Task<ResponseInfo<bool>> ExecuteAsync(
        CreateReviewerRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
