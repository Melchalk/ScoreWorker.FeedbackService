using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Responses;
using FeedbackService.Models.Dto.Responses.Reviewer;

namespace FeedbackService.Business.Reviewer;

public class GetReviewerCommand(IReviewerRepository repository) : IGetReviewerCommand
{
    public Task<ResponseInfo<GetReviewerResponse>> ExecuteAsync(
        Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
