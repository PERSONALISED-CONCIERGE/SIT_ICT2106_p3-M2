using personalised_concierge_m1.Models.Entities.Facilities;
using personalised_concierge_m1.Models.Interfaces.Facilities;

namespace personalised_concierge_m1.Data.Facilities
{
    public class FacilityBookingRepo : GenericRepo<FacilityBooking>, IFacilityBookingRepo
    {
        public FacilityBookingRepo(ConciergeContext context) : base(context)
        {
            
        }

        public IFacilityBookingRepo getAllFacilityBooking()
        {
            throw new System.NotImplementedException();
        }

        public IFacilityBookingRepo getFacilityBookingById(int facilitybooking_id)
        {
            throw new System.NotImplementedException();
        }
    }
}