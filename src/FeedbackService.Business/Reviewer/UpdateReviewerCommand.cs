using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Requests.Reviewer;

namespace FeedbackService.Business.Reviewer;

public class UpdateReviewerCommand(IReviewerRepository repository) : IUpdateReviewerCommand
{
    public Task ExecuteAsync(
        UpdateReviewerRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
