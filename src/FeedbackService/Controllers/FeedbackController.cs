﻿using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Models.Dto.Requests.Feedback;
using FeedbackService.Models.Dto.Responses;
using FeedbackService.Models.Dto.Responses.Feedback;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace FeedbackService.Controllers;

[SwaggerTag("Управление отзывами")]
[Authorize]
[ApiController]
[Route("api/feedback")]
[Produces("application/json")]
public class FeedbackController : ControllerBase
{
    [HttpPost("create")]
    public async Task<ResponseInfo<bool>> CreateAsync(
      [FromServices] ICreateFeedbackCommand command,
      [FromBody] CreateFeedbackRequest request,
      CancellationToken cancellationToken)
    {
        return await command.ExecuteAsync(request, cancellationToken);
    }

    [HttpGet("get")]
    public async Task<ResponseInfo<GetFeedbackResponse>> GetAsync(
      [FromServices] IGetFeedbackCommand command,
      [FromQuery] Guid id,
      CancellationToken cancellationToken)
    {
        return await command.ExecuteAsync(id, cancellationToken);
    }

    [HttpPut("update")]
    public async Task<ResponseInfo<bool>> UpdateAsync(
      [FromServices] IUpdateFeedbackCommand command,
      [FromBody] UpdateFeedbackRequest request,
      CancellationToken cancellationToken)
    {
        return await command.ExecuteAsync(request, cancellationToken);
    }

    [HttpDelete("remove")]
    public async Task<ResponseInfo<bool>> RemoveAsync(
      [FromServices] IDeleteFeedbackCommand command,
      [FromQuery] Guid id,
      CancellationToken cancellationToken)
    {
        return await command.ExecuteAsync(id, cancellationToken);
    }
}
