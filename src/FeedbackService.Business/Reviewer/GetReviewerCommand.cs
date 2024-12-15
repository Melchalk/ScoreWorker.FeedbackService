using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Models.Dto.Responses;
using FeedbackService.Models.Dto.Responses.Reviewer;

namespace FeedbackService.Business.Reviewer;

public class GetReviewerCommand : IGetReviewerCommand
{
    public Task<ResponseInfo<GetReviewerResponse>> ExecuteAsync(
        Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
