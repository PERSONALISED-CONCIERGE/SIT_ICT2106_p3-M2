using personalised_concierge_m1.Models.Entities.Itineraries;


namespace personalised_concierge_m1.Models.Interfaces.Itineraries
{
    public interface IItineraryItemRepo : IGenericRepo<ItineraryItem>
    {
        IItineraryItemRepo getAllItineraryItems();
        IItineraryItemRepo getItineraryItemById(int itinerary_item_id);
    }
}
