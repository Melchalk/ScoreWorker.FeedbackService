﻿using FeedbackService.Data.Interfaces;
using FeedbackService.Data.Provider;
using FeedbackService.Models.Db;

namespace FeedbackService.Data;

public class FeedbackRepository(IDataProvider provider) : IFeedbackRepository
{
    public Task CreateAsync(DbFeedback dbFeedback)
    {
        throw new NotImplementedException();
    }

    public Task DeleteAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task<DbFeedback> GetAsync(Guid id)
    {
        throw new NotImplementedException();
    }

    public Task UpdateAsync(DbFeedback dbFeedback)
    {
        throw new NotImplementedException();
    }
}
