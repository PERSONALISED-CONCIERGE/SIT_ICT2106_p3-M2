using personalised_concierge_m1.Models.Entities.OtherServices;
using personalised_concierge_m1.Models.Interfaces.OtherServices;

namespace personalised_concierge_m1.Data.OtherServices
{
    public class TransportationRepo : GenericRepo<Transportation>,ITransportationRepo
    {
        public TransportationRepo(ConciergeContext context) : base(context)
        {
        }
        
        //implementation of non-generic interface methods
        public ITransportationRepo getAllTransportations()
        {
            throw new System.NotImplementedException();

        }
        
        public ITransportationRepo getTransportationById(int transport_id)
        {
            throw new System.NotImplementedException();
        }
    }
}