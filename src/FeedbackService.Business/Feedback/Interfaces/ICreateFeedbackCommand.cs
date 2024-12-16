using FeedbackService.Models.Dto.Requests.Feedback;

namespace FeedbackService.Business.Feedback.Interfaces;

public interface ICreateFeedbackCommand
{
    Task ExecuteAsync(CreateFeedbackRequest request, CancellationToken cancellationToken);
}
