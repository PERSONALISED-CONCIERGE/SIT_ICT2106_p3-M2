using personalised_concierge_m1.Models.Entities.RoomDetails;
using personalised_concierge_m1.Models.Interfaces.RoomDetails;

namespace personalised_concierge_m1.Data.RoomDetails
{
    
    public class ReservationRepo : GenericRepo<Reservation>, IReservationRepo
    {
        public ReservationRepo(ConciergeContext context) : base(context)
        {
        }
        public IReservationRepo getAllReservations()
        {
            throw new System.NotImplementedException();
        }
        public IReservationRepo getReservationById(int reservation_id)
        {
            throw new System.NotImplementedException();
        }
    }
}