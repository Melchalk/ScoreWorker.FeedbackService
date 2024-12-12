using FeedbackService.Data.Interfaces;
using FeedbackService.Data.Provider;

namespace FeedbackService.Data;

public class FeedbackRepository(IDataProvider provider) : IFeedbackRepository
{
}
