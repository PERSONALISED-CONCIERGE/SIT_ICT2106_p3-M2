using personalised_concierge_m1.Models.Entities.Requests;
using personalised_concierge_m1.Models.Interfaces.Requests;

namespace personalised_concierge_m1.Data.Requests
{
    public class RequestTypeRepo:GenericRepo<RequestType>,IRequestTypeRepo
    {
        public RequestTypeRepo(ConciergeContext context) : base(context)
        {
            
        }

        //implementation of non-generic interface methods
        public IRequestTypeRepo getAllRequestType()
        {
            throw new System.NotImplementedException();
        }

        public IRequestTypeRepo getRequestTypeById(int request_id)
        {
            throw new System.NotImplementedException();
        }
    }
}