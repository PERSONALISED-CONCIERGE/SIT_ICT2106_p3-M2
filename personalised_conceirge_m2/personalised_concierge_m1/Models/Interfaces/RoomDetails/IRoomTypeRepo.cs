using personalised_concierge_m1.Models.Entities.RoomDetails;

namespace personalised_concierge_m1.Models.Interfaces
{
    public interface IRoomTypeRepo : IGenericRepo<RoomType>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        IRoomTypeRepo getAllRoomTypes();
        IRoomTypeRepo getRoomTypeById(int roomtype_id);   
    }
}