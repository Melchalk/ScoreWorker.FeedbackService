using FeedbackService.Models.Dto.Responses;
using FeedbackService.Models.Dto.Responses.Reviewer;

namespace FeedbackService.Business.Reviewer.Interfaces;

public interface IGetReviewerCommand
{
    Task<ResponseInfo<GetReviewerResponse>> ExecuteAsync(Guid id, CancellationToken cancellationToken);
}
