using System.Collections.Generic;
using System.Linq;
using personalised_concierge_m1.Models.Entities.OtherServices;
using personalised_concierge_m1.Models.Interfaces.OtherServices;

namespace personalised_concierge_m1.Data.OtherServices
{
    public class TransportFaresRepo : GenericRepo<TransportFares>, ITransportFaresRepo
    {
        public TransportFaresRepo(ConciergeContext context) : base(context)
        {
        }

        public IEnumerable<TransportFares> GetAllTransportFares()
        {
            return _context.Set<TransportFares>().ToList();
        }
        public TransportFares GetTransportFareByID(int transportfare_id)
        {
            return _context.Set<TransportFares>().Find(transportfare_id);
        }


    }
}