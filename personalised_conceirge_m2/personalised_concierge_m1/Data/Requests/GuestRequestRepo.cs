using personalised_concierge_m1.Models.Entities.Requests;
using personalised_concierge_m1.Models.Interfaces.Requests;

namespace personalised_concierge_m1.Data.Requests
{
    public class GuestRequestRepo:GenericRepo<GuestRequest>,IGuestRequestRepo
    {
        public GuestRequestRepo(ConciergeContext context) : base(context)
        {
        }

        //implementation of non-generic interface methods
        public IGuestRequestRepo getAllGuestRequest()
        {
            throw new System.NotImplementedException();
        }
        public IGuestRequestRepo getGuestRequestById(int guest_id, int request_id)
        {
            throw new System.NotImplementedException();
        }
    }
}