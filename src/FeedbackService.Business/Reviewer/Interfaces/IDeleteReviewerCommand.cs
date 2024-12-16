namespace FeedbackService.Business.Reviewer.Interfaces;

public interface IDeleteReviewerCommand
{
    Task ExecuteAsync(Guid id, CancellationToken cancellationToken);
}
