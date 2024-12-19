using FeedbackService.Broker.Models;
using FeedbackService.Broker.Publishers.Interfaces;
using MassTransit;

namespace FeedbackService.Broker.Publishers;

public class UserService(IRequestClient<GetUserIdsByTeamRequest> rcGetUserIds) : IUserService
{
    public Task<GetUserIdsByTeamResponse> GetUsersIdByTeam(
        GetUserIdsByTeamRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
