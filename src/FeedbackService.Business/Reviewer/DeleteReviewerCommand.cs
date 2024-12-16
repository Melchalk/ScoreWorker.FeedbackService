using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Exceptions;

namespace FeedbackService.Business.Reviewer;

public class DeleteReviewerCommand(
    IReviewerRepository reviewerRepository,
    IFeedbackRepository feedbackRepository)
    : IDeleteReviewerCommand
{
    public async Task ExecuteAsync(Guid id, CancellationToken cancellationToken)
    {
        var resultDeletion = await reviewerRepository.DeleteAsync(id, cancellationToken);

        if (!resultDeletion)
        {
            throw new BadRequestException($"Reviewer with id = '{id}' was not found.");
        }

        await feedbackRepository.SetDismissedUser(id, cancellationToken);
    }
}
