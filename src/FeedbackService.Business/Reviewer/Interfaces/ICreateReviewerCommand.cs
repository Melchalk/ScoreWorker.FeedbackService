using FeedbackService.Models.Dto.Requests.Reviewer;
using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Reviewer.Interfaces;

public interface ICreateReviewerCommand
{
    Task<ResponseInfo<Guid>> ExecuteAsync(CreateReviewerRequest request, CancellationToken cancellationToken);
}