using personalised_concierge_m1.Models.Entities.Requests;
using personalised_concierge_m1.Models.Interfaces.Requests;

namespace personalised_concierge_m1.Data.Requests
{
    public class RequestRepo:GenericRepo<Request>,IRequestRepo
    {
        public RequestRepo(ConciergeContext context) : base(context)
        {
            
        }

        //implementation of non-generic interface methods
        public IRequestRepo getAllRequest()
        {
            throw new System.NotImplementedException();
        }
        
        public IRequestRepo getRequestById(int request_id)
        {
            throw new System.NotImplementedException();
        }
    }
}