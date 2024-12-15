using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Models.Dto.Requests.Feedback;
using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Feedback;

public class UpdateFeedbackCommand : IUpdateFeedbackCommand
{
    public Task<ResponseInfo<bool>> ExecuteAsync(
        UpdateFeedbackRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
