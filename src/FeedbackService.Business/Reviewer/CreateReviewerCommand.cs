using AutoMapper;
using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Db;
using FeedbackService.Models.Dto.Requests.Reviewer;
using FeedbackService.Models.Dto.Responses;
using System.Net;

namespace FeedbackService.Business.Reviewer;

public class CreateReviewerCommand(
    IMapper mapper,
    IReviewerRepository repository) : ICreateReviewerCommand
{
    public async Task<ResponseInfo<Guid>> ExecuteAsync(
        CreateReviewerRequest request,
        CancellationToken cancellationToken)
    {
        var reviewer = mapper.Map<DbReviewer>(request);

        var result = await repository.CreateAsync(reviewer, cancellationToken);

        return new ResponseInfo<Guid>
        {
            Body = result,
            Status = (int)HttpStatusCode.Created
        };
    }
}
