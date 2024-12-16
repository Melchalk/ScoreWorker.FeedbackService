using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Data.Interfaces;

namespace FeedbackService.Business.Feedback;

public class GetFeedbackForUserCommand(IFeedbackRepository repository) : IGetFeedbackForUserCommand
{
}
