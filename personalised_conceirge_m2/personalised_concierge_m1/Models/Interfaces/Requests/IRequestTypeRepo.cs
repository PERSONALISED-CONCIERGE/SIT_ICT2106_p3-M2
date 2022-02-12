using personalised_concierge_m1.Models.Entities.Requests;

namespace personalised_concierge_m1.Models.Interfaces.Requests
{
    public interface IRequestTypeRepo:IGenericRepo<RequestType>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        IRequestTypeRepo getAllRequestType();
        IRequestTypeRepo getRequestTypeById(int requesttype_id);
    }
}