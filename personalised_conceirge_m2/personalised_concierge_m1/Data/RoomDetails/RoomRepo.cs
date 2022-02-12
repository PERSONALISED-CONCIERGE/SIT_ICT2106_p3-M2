using personalised_concierge_m1.Models.Entities.RoomDetails;
using personalised_concierge_m1.Models.Interfaces.RoomDetails;

namespace personalised_concierge_m1.Data.RoomDetails
{
    public class RoomRepo : GenericRepo<Room>, IRoomRepo
    {
        public RoomRepo(ConciergeContext context) : base(context)
        {
        }

        public IRoomRepo getAllRooms()
        {
            throw new System.NotImplementedException();
        }

        public IRoomRepo getRoomDetailById(int room_Id)
        {
            throw new System.NotImplementedException();
        }
    }
}