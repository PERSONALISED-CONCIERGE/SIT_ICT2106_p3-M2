using personalised_concierge_m1.Models.Entities.RoomDetails;

namespace personalised_concierge_m1.Models.Interfaces.RoomDetails
{
    public interface IRoomRepo : IGenericRepo<Room>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.

        //Room Entity 
        IRoomRepo getAllRooms();
        IRoomRepo getRoomDetailById (int room_Id);
    }
}