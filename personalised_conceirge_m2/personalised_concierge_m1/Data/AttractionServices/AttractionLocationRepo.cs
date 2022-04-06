using personalised_concierge_m1.Models.Entities.Attraction;
using personalised_concierge_m1.Models.Interfaces.Attraction;

namespace personalised_concierge_m1.Data.AttractionServices
{
    public class AttractionLocationRepo : GenericRepo<Attraction>, IAttractionLocationRepo
    {
        public AttractionLocationRepo(ConciergeContext context) : base(context)
        {
        }
        public IAttractionLocationRepo getAllAttractionLocations()
        {
            throw new System.NotImplementedException();
        }

    }
}