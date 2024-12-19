using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Reviewer.Interfaces;

public interface IDeleteReviewerCommand
{
    Task<ResponseInfo<bool>> ExecuteAsync(Guid id, CancellationToken cancellationToken);
}
