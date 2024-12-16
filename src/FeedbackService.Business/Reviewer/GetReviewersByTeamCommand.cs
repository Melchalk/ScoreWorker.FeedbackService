using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Data.Interfaces;

namespace FeedbackService.Business.Reviewer;

public class GetReviewersByTeamCommand(IReviewerRepository repository) : IGetReviewersByTeamCommand
{
}
