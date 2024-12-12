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

}
