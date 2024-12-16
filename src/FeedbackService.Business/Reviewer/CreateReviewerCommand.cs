using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Requests.Reviewer;
using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Reviewer;

public class CreateReviewerCommand(IReviewerRepository repository) : ICreateReviewerCommand
{
    public Task<ResponseInfo<bool>> ExecuteAsync(
        CreateReviewerRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
