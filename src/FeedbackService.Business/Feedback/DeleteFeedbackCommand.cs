using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Exceptions;

namespace FeedbackService.Business.Feedback;

public class DeleteFeedbackCommand(IFeedbackRepository repository) : IDeleteFeedbackCommand
{
    public async Task ExecuteAsync(
        Guid id, CancellationToken cancellationToken)
    {
        if (!(await repository.DeleteAsync(id, cancellationToken)))
        {
            throw new BadRequestException($"Feedback with id = '{id}' was not found.");
        }
    }
}
