using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Exceptions;
using FeedbackService.Models.Dto.Responses;
using System.Net;

namespace FeedbackService.Business.Feedback;

public class DeleteFeedbackCommand(IFeedbackRepository repository) : IDeleteFeedbackCommand
{
    public async Task<ResponseInfo<bool>> ExecuteAsync(
        Guid id, CancellationToken cancellationToken)
    {
        var result = await repository.DeleteAsync(id, cancellationToken);

        if (!result)
            throw new BadRequestException($"Feedback with id = '{id}' was not found.");

        return new ResponseInfo<bool>
        {
            Body = result,
            Status = (int)HttpStatusCode.OK,
        };
    }
}
