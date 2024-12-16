using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Models.Dto.Requests.Feedback;
using MassTransit;

namespace FeedbackService.Broker.Consumers;

public class GetFeedbackForUserConsumer(
    IGetFeedbackForUserCommand command)
    : IConsumer<GetFeedbackForUserRequest>
{
    public async Task Consume(ConsumeContext<GetFeedbackForUserRequest> context)
    {
        var actionResult = await command
            .ExecuteAsync(context.Message.UserId, cancellationToken: default);

        await context.RespondAsync(actionResult);
    }
}
