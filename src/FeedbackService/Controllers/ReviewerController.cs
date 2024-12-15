using FeedbackService.Business.Reviewer.Interfaces;
using FeedbackService.Models.Dto.Requests.Reviewer;
using FeedbackService.Models.Dto.Responses;
using FeedbackService.Models.Dto.Responses.Reviewer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace FeedbackService.Controllers;

[SwaggerTag("Управление рецензентами")]
[Authorize]
[ApiController]
[Route("api/reviewer")]
[Produces("application/json")]
public class ReviewerController : ControllerBase
{
    [HttpPost("create")]
    public async Task<ResponseInfo<bool>> CreateAsync(
      [FromServices] ICreateReviewerCommand command,
      [FromBody] CreateReviewerRequest request,
      CancellationToken cancellationToken)
    {
        return await command.ExecuteAsync(request, cancellationToken);
    }

    [HttpGet("get")]
    public async Task<ResponseInfo<GetReviewerResponse>> GetAsync(
      [FromServices] IGetReviewerCommand command,
      [FromQuery] Guid id,
      CancellationToken cancellationToken)
    {
        return await command.ExecuteAsync(id, cancellationToken);
    }

    [HttpPut("update")]
    public async Task<ResponseInfo<bool>> UpdateAsync(
      [FromServices] IUpdateReviewerCommand command,
      [FromBody] UpdateReviewerRequest request,
      CancellationToken cancellationToken)
    {
        return await command.ExecuteAsync(request, cancellationToken);
    }

    [HttpDelete("remove")]
    public async Task<ResponseInfo<bool>> RemoveAsync(
      [FromServices] IDeleteReviewerCommand command,
      [FromQuery] Guid id,
      CancellationToken cancellationToken)
    {
        return await command.ExecuteAsync(id, cancellationToken);
    }
}
