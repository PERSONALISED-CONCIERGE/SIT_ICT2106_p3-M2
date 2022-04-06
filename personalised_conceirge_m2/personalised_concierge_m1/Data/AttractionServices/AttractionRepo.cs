using personalised_concierge_m1.Models.Entities.Attraction;
using personalised_concierge_m1.Models.Interfaces.Attraction;

namespace personalised_concierge_m1.Data.AttractionServices
{
    public class AttractionRepo : GenericRepo<Attraction>, IAttractionRepo
    {
        public AttractionRepo(ConciergeContext context) : base(context)
        {
        }
        public IAttractionRepo getAllAttractions()
        {
            throw new System.NotImplementedException();
        }

    }
}