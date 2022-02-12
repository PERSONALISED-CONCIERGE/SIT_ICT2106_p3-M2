using personalised_concierge_m1.Models.Entities.Facilities;

namespace personalised_concierge_m1.Models.Interfaces.Facilities
{
    public interface IFacilityRepo : IGenericRepo<Facility>
    {
        IFacilityRepo getAllFacility();
        
        IFacilityRepo getFacilityById(int facility_id);
    }
}