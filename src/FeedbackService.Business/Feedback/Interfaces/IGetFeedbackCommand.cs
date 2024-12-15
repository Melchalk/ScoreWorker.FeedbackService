using FeedbackService.Models.Dto.Responses;
using FeedbackService.Models.Dto.Responses.Feedback;

namespace FeedbackService.Business.Feedback.Interfaces;

public interface IGetFeedbackCommand
{
    Task<ResponseInfo<GetFeedbackResponse>> ExecuteAsync(Guid id, CancellationToken cancellationToken);
}
