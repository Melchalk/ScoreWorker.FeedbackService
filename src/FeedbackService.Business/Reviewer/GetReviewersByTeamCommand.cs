using AutoMapper;
using FeedbackService.Broker.Models;
using FeedbackService.Broker.Publishers.Interfaces;
using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Responses;
using FeedbackService.Models.Dto.Responses.Reviewer;
using Microsoft.EntityFrameworkCore;
using System.Net;

namespace FeedbackService.Business.Reviewer;

public class GetReviewersByTeamCommand(
    IUserService userService,
    IMapper mapper,
    IReviewerRepository repository) : IGetReviewersByTeamCommand
{
    public async Task<ResponseInfo<List<GetReviewerResponse>>> ExecuteAsync(
        Guid teamId, CancellationToken cancellationToken)
    {
        var teamRequest = new GetUserIdsByTeamRequest { TeamId = teamId };

        GetUserIdsByTeamResponse userIds = await userService
            .GetUsersIdByTeam(teamRequest, cancellationToken);

        var dbReviewers = repository.GetByUserIds(userIds.UserIds);

        var reviewers = dbReviewers is not null
            ? await mapper.ProjectTo<GetReviewerResponse>(dbReviewers)
                .ToListAsync(cancellationToken)
            : [];

        return new ResponseInfo<List<GetReviewerResponse>>
        {
            Body = reviewers,
            Status = (int)HttpStatusCode.OK,
        };

    }
}
