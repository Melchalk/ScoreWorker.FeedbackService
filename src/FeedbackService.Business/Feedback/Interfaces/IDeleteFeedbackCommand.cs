using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Feedback.Interfaces;

public interface IDeleteFeedbackCommand
{
    Task<ResponseInfo<bool>> ExecuteAsync(Guid id, CancellationToken cancellationToken);
}
