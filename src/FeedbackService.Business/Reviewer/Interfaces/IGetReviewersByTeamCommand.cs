using FeedbackService.Models.Dto.Responses.Reviewer;
using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Reviewer.Interfaces;

public interface IGetReviewersByTeamCommand
{
    Task<ResponseInfo<List<GetReviewerResponse>>> ExecuteAsync(Guid teamId, CancellationToken cancellationToken);
}
