using FeedbackService.Models.Dto.Responses.Feedback;
using FeedbackService.Models.Dto.Responses;
using FeedbackService.Models.Dto.Requests.Feedback;

namespace FeedbackService.Business.Feedback.Interfaces;

public interface IGetFeedbackForUserCommand
{
    Task<ResponseInfo<GetFeedbackForUserResponse>> ExecuteAsync(Guid id, CancellationToken cancellationToken);
}
