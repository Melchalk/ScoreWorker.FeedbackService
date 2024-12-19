using AutoMapper;
using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Db;
using FeedbackService.Models.Dto.Requests.Feedback;
using FeedbackService.Models.Dto.Responses;
using System.Net;

namespace FeedbackService.Business.Feedback;

public class CreateFeedbackCommand(
    IMapper mapper,
    IFeedbackRepository repository) : ICreateFeedbackCommand
{
    public async Task<ResponseInfo<Guid>> ExecuteAsync(
        CreateFeedbackRequest request,
        CancellationToken cancellationToken)
    {
        var feedback = mapper.Map<DbFeedback>(request);

        var result = await repository.CreateAsync(feedback, cancellationToken);

        return new ResponseInfo<Guid>
        {
            Body = result,
            Status = (int)HttpStatusCode.Created
        };
    }
}
