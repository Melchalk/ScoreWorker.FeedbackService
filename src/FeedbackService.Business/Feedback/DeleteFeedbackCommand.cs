﻿using FeedbackService.Business.Feedback.Interfaces;
using FeedbackService.Models.Dto.Responses;

namespace FeedbackService.Business.Feedback;

public class DeleteFeedbackCommand : IDeleteFeedbackCommand
{
    public Task<ResponseInfo<bool>> ExecuteAsync(Guid id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }
}
