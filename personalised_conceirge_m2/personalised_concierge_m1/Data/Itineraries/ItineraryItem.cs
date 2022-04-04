using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Models.Interfaces.Itineraries;
using System.Collections.Generic;
using System.Linq;

namespace personalised_concierge_m1.Data.Itineraries
{
    public class ItineraryItemRepo : GenericRepo<ItineraryItem>, IItineraryItemRepo
    {
        public ItineraryItemRepo(ConciergeContext context) : base(context)
        {
        }
        public IItineraryItemRepo getAllItineraryItems()
        {
            throw new System.NotImplementedException();
        }
        public IItineraryItemRepo getItineraryItemById(int itinerary_item_id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<ItineraryItem> GetByItineraryID(int itinerary_id)
        {
            return _context.ItineraryItems.Where(ItineraryItem => ItineraryItem.itinerary_id == itinerary_id).ToList();
        }
    }
}
