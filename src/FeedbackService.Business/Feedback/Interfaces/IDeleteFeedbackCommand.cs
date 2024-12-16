using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Feedback.Interfaces;

public interface IDeleteFeedbackCommand
{
    Task ExecuteAsync(Guid id, CancellationToken cancellationToken);
}
