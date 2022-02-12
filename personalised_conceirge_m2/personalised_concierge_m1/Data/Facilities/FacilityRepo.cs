using personalised_concierge_m1.Models.Entities.Facilities;
using personalised_concierge_m1.Models.Interfaces.Facilities;

namespace personalised_concierge_m1.Data.Facilities
{
    public class FacilityRepo : GenericRepo<Facility>, IFacilityRepo
    {
        public FacilityRepo(ConciergeContext context) : base(context)
        {
            
        }

        public IFacilityRepo getAllFacility()
        {
            throw new System.NotImplementedException();
        }

        public IFacilityRepo getFacilityById(int facility_id)
        {
            throw new System.NotImplementedException();
        }
    }
}