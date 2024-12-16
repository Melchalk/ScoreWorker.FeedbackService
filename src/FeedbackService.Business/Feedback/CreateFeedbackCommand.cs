﻿using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Data.Interfaces;
using FeedbackService.Models.Dto.Requests.Feedback;
using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Feedback;

public class CreateFeedbackCommand(IFeedbackRepository repository) : ICreateFeedbackCommand
{
    public Task<ResponseInfo<bool>> ExecuteAsync(
        CreateFeedbackRequest request,
        CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
