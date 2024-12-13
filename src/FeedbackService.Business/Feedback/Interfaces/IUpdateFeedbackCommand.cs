﻿using FeedbackService.Models.Dto.Requests.Feedback;
using FeedbackService.Models.Dto.Responses;
using System.Threading;

namespace FeedbackService.Business.Feedback.Interfaces;

public interface IUpdateFeedbackCommand
{
    Task ExecuteAsync(UpdateFeedbackRequest request, CancellationToken cancellationToken);
}
