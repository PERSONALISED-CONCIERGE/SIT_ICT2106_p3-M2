using personalised_concierge_m1.Models.Entities.OtherServices;
using personalised_concierge_m1.Models.Interfaces.OtherServices;

namespace personalised_concierge_m1.Data.OtherServices
{
    public class TransportFaresRepo : GenericRepo<TransportFares>, ITransportFaresRepo
    {
        public TransportFaresRepo(ConciergeContext context) : base(context)
        {
        }

        //implementation of non-generic interface methods
        public ITransportFaresRepo getAllTransportFares()
        {
            throw new System.NotImplementedException();
        }

        public ITransportFaresRepo getTransportFaresRepoById(int fare_id)
        {
            throw new System.NotImplementedException();
        }


    }
}