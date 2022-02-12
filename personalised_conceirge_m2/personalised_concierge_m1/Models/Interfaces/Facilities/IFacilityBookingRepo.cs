using personalised_concierge_m1.Models.Entities.Facilities;

namespace personalised_concierge_m1.Models.Interfaces.Facilities
{
    public interface IFacilityBookingRepo : IGenericRepo<FacilityBooking>
    {
        IFacilityBookingRepo getAllFacilityBooking();
        
        IFacilityBookingRepo getFacilityBookingById(int facilitybooking_id);
    }
}