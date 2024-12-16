using FeedbackService.Models.Dto.Requests.Reviewer;

namespace FeedbackService.Business.Reviewer.Interfaces;

public interface ICreateReviewerCommand
{
    Task ExecuteAsync(CreateReviewerRequest request, CancellationToken cancellationToken);
}