using personalised_concierge_m1.Models.Entities.Facilities;
using personalised_concierge_m1.Models.Interfaces.Facilities;

namespace personalised_concierge_m1.Data.Facilities
{
    public class FeedbackRepo : GenericRepo<Feedback>, IFeedbackRepo
    {
        public FeedbackRepo(ConciergeContext context) : base(context)
        {
            
        }

        public IFeedbackRepo getAllFeedback()
        {
            throw new System.NotImplementedException();
        }

        public IFeedbackRepo getFeedbackById(int feedback_id)
        {
            throw new System.NotImplementedException();
        }
    }
}