using FeedbackService.Models.Dto.Requests.Feedback;
using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Feedback.Interfaces;

public interface ICreateFeedbackCommand
{
    Task<ResponseInfo<Guid>> ExecuteAsync(CreateFeedbackRequest request, CancellationToken cancellationToken);
}
