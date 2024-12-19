using AutoMapper;
using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Exceptions;
using FeedbackService.Models.Dto.Responses;
using FeedbackService.Models.Dto.Responses.Reviewer;
using System.Net;

namespace FeedbackService.Business.Reviewer;

public class GetReviewerCommand(
    IMapper mapper,
    IReviewerRepository repository) : IGetReviewerCommand
{
    public async Task<ResponseInfo<GetReviewerResponse>> ExecuteAsync(
        Guid id, CancellationToken cancellationToken)
    {
        var dbReviewer = await repository.GetAsync(id, cancellationToken)
            ?? throw new BadRequestException($"Reviewer with id = '{id}' was not found.");

        var reviewer = mapper.Map<GetReviewerResponse>(dbReviewer);

        return new ResponseInfo<GetReviewerResponse>
        {
            Body = reviewer,
            Status = (int)HttpStatusCode.OK,
        };
    }
}
