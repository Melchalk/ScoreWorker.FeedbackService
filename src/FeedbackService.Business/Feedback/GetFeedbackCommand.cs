using AutoMapper;
using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Exceptions;
using FeedbackService.Models.Dto.Responses;
using FeedbackService.Models.Dto.Responses.Feedback;
using System.Net;

namespace FeedbackService.Business.Feedback;

public class GetFeedbackCommand(
    IMapper mapper,
    IFeedbackRepository repository) : IGetFeedbackCommand
{
    public async Task<ResponseInfo<GetFeedbackResponse>> ExecuteAsync(
        Guid id, CancellationToken cancellationToken)
    {
        var dbFeedback = await repository.GetAsync(id, cancellationToken)
            ?? throw new BadRequestException($"Feedback with id = '{id}' was not found.");

        var feedback = mapper.Map<GetFeedbackResponse>(dbFeedback);

        return new ResponseInfo<GetFeedbackResponse>
        {
            Body = feedback,
            Status = (int)HttpStatusCode.OK,
        };
    }
}
