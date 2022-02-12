using personalised_concierge_m1.Models.Entities.Itineraries;


namespace personalised_concierge_m1.Models.Interfaces.Itineraries
{
    public interface IItineraryRepo : IGenericRepo<Itinerary>
    {
        IItineraryRepo getAllItinerary();
        IItineraryRepo getItineraryById(int itinerary_id);
    }
}
