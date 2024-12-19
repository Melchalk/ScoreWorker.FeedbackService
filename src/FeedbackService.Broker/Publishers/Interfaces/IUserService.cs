using FeedbackService.Broker.Models;

namespace FeedbackService.Broker.Publishers.Interfaces;

public interface IUserService
{
    Task<GetUserIdsByTeamResponse> GetUsersIdByTeam(GetUserIdsByTeamRequest request, CancellationToken cancellationToken);
}
