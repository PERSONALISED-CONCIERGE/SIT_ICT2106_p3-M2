using personalised_concierge_m1.Models.Entities.HotelServices;
using personalised_concierge_m1.Models.Interfaces.HotelServices;

namespace personalised_concierge_m1.Data.HotelServices
{
    public class HotelServiceRepo : GenericRepo<HotelService>, IHotelServiceRepo
    {
        public HotelServiceRepo(ConciergeContext context) : base(context)
        {
        }
        public IHotelServiceRepo getAllHotelServices ()
        {
            throw new System.NotImplementedException();
        }
        public IHotelServiceRepo getHotelServiceById(int service_id)
        {
            throw new System.NotImplementedException();
        }
    }
}