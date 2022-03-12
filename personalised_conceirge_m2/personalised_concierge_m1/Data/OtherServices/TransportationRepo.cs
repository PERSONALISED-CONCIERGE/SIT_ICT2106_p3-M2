using System.Collections.Generic;
using System.Linq;
using personalised_concierge_m1.Models.Entities.OtherServices;
using personalised_concierge_m1.Models.Interfaces.OtherServices;

namespace personalised_concierge_m1.Data.OtherServices
{
    public class TransportationRepo : GenericRepo<Transportation>,ITransportationRepo
    {
        public TransportationRepo(ConciergeContext context) : base(context)
        {
        }
        
        public IEnumerable<Transportation> GetAllTransportations()
        {
            return _context.Set<Transportation>().ToList();
        }

        public Transportation GetTransportationByID(int transport_id)
        {
            return _context.Set<Transportation>().Find(transport_id);
        }
    }
}