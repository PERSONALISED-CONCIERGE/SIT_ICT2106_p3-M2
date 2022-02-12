using personalised_concierge_m1.Models.Entities.HotelServices;

namespace personalised_concierge_m1.Models.Interfaces.HotelServices
{
    public interface IHotelServiceRepo : IGenericRepo<HotelService>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        IHotelServiceRepo getAllHotelServices();
        IHotelServiceRepo getHotelServiceById(int service_id);   
    }
}