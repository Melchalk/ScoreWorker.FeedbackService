using AutoMapper;
using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Db;
using FeedbackService.Models.Dto.Requests.Feedback;

namespace FeedbackService.Business.Feedback;

public class CreateFeedbackCommand(
    IMapper mapper,
    IFeedbackRepository repository) : ICreateFeedbackCommand
{
    public async Task ExecuteAsync(
        CreateFeedbackRequest request,
        CancellationToken cancellationToken)
    {
        var feedback = mapper.Map<DbFeedback>(request);

        await repository.CreateAsync(feedback, cancellationToken);
    }
}
