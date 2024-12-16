using AutoMapper;
using FeedbackService.Models.Db;
using FeedbackService.Models.Dto.Requests.Feedback;
using FeedbackService.Models.Dto.Requests.Reviewer;
using FeedbackService.Models.Dto.Responses.Feedback;

namespace FeedbackService.Infrastructure.Mapper;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        #region Feedback

        CreateMap<DbFeedback, GetFeedbackResponse>().ReverseMap();
        CreateMap<DbFeedback, CreateFeedbackRequest>().ReverseMap();

        #endregion

        #region Reviewer

        CreateMap<DbReviewer, CreateReviewerRequest>().ReverseMap();

        #endregion
    }
}
