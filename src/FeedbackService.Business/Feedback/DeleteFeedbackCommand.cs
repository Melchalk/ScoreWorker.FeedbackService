using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Feedback;

public class DeleteFeedbackCommand(IFeedbackRepository repository) : IDeleteFeedbackCommand
{
    public Task<ResponseInfo<bool>> ExecuteAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
