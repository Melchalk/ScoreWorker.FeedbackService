using AutoMapper;
using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Exceptions;
using FeedbackService.Models.Dto.Responses;
using FeedbackService.Models.Dto.Responses.Feedback;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace FeedbackService.Business.Feedback;

public class GetFeedbackForUserCommand(
    IMapper mapper,
    IReviewerRepository repository) : IGetFeedbackForUserCommand
{
    public async Task<ResponseInfo<GetFeedbackForUserResponse>> ExecuteAsync(
        Guid id, CancellationToken cancellationToken)
    {
        var reviewer = await repository.GetWithFeedbackByUserIdAsync(id, cancellationToken)
            ?? throw new BadRequestException("Reviewer was not found.");

        var feedbacks = reviewer.Feedbacks is not null
            ? await mapper.ProjectTo<GetFeedbackResponse>(reviewer.Feedbacks.AsQueryable())
                .ToListAsync(cancellationToken)
            : [];

        return new ResponseInfo<GetFeedbackForUserResponse>
        {
            Body = new GetFeedbackForUserResponse
            {
                Feedbacks = feedbacks
            },
            Status = (int)HttpStatusCode.OK,
        };
    }
}
