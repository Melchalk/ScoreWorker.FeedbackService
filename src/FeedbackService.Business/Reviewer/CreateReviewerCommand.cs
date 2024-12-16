using AutoMapper;
using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Db;
using FeedbackService.Models.Dto.Requests.Reviewer;

namespace FeedbackService.Business.Reviewer;

public class CreateReviewerCommand(
    IMapper mapper,
    IReviewerRepository repository) : ICreateReviewerCommand
{
    public async Task ExecuteAsync(
        CreateReviewerRequest request,
        CancellationToken cancellationToken)
    {
        var reviewer = mapper.Map<DbReviewer>(request);

        await repository.CreateAsync(reviewer, cancellationToken);
    }
}
