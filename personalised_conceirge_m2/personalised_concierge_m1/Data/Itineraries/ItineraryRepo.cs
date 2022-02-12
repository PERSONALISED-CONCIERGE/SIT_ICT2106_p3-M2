using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Models.Interfaces.Itineraries;

namespace personalised_concierge_m1.Data.Itineraries
{
    public class ItineraryRepo : GenericRepo<Itinerary>, IItineraryRepo
    {
        public ItineraryRepo(ConciergeContext context) : base(context)
        {
        }
        public IItineraryRepo getAllItinerary()
        {
            throw new System.NotImplementedException();
        }
        public IItineraryRepo getItineraryById(int itinerary_id)
        {
            throw new System.NotImplementedException();
        }
    }
}
