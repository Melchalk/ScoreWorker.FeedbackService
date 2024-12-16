namespace FeedbackService.Models.Dto.Responses.Feedback;

public class GetFeedbackForUserResponse
{
    public required List<GetFeedbackResponse> Feedbacks { get; set; }
}
