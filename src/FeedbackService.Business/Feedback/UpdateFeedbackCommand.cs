using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Requests.Feedback;

namespace FeedbackService.Business.Feedback;

public class UpdateFeedbackCommand(IFeedbackRepository repository) : IUpdateFeedbackCommand
{
    public Task ExecuteAsync(
        UpdateFeedbackRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
