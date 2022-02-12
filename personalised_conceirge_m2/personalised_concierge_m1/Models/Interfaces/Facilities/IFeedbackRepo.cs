using personalised_concierge_m1.Models.Entities.Facilities;

namespace personalised_concierge_m1.Models.Interfaces.Facilities
{
    public interface IFeedbackRepo : IGenericRepo<Feedback>
    {
        IFeedbackRepo getAllFeedback();

        IFeedbackRepo getFeedbackById(int feedback_id);
    }
}