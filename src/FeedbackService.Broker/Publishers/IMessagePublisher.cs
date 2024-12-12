﻿namespace FeedbackService.Broker.Publishers;

public interface IMessagePublisher<T, U>
{
    Task<U> SendMessageAsync(T request);
}