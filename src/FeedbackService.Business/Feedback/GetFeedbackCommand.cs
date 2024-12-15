using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Models.Dto.Responses;
using FeedbackService.Models.Dto.Responses.Feedback;

namespace FeedbackService.Business.Feedback;

public class GetFeedbackCommand : IGetFeedbackCommand
{
    public Task<ResponseInfo<GetFeedbackResponse>> ExecuteAsync(
        Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
