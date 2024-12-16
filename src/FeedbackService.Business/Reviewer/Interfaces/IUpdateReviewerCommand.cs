using FeedbackService.Models.Dto.Requests.Reviewer;

namespace FeedbackService.Business.Reviewer.Interfaces;

public interface IUpdateReviewerCommand
{
    Task ExecuteAsync(UpdateReviewerRequest request, CancellationToken cancellationToken);
}
