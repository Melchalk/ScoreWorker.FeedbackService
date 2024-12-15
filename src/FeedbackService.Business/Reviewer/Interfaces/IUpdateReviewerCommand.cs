using FeedbackService.Models.Dto.Requests.Reviewer;
using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Reviewer.Interfaces;

public interface IUpdateReviewerCommand
{
    Task<ResponseInfo<bool>> ExecuteAsync(UpdateReviewerRequest request, CancellationToken cancellationToken);
}
