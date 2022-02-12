using personalised_concierge_m1.Models.Entities.RoomDetails;
using personalised_concierge_m1.Models.Interfaces;

namespace personalised_concierge_m1.Data.RoomDetails
{
    public class RoomTypeRepo : GenericRepo<RoomType>, IRoomTypeRepo
    {
        public RoomTypeRepo(ConciergeContext context) : base(context)
        {
        }
        public IRoomTypeRepo getAllRoomTypes()
        {
            throw new System.NotImplementedException();
        }
        public IRoomTypeRepo getRoomTypeById(int roomtype_id)
        {
            throw new System.NotImplementedException();
        }
    }
}