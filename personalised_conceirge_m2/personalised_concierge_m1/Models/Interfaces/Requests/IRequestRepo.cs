using personalised_concierge_m1.Models.Entities.Requests;

namespace personalised_concierge_m1.Models.Interfaces.Requests
{
    public interface IRequestRepo:IGenericRepo<Request>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        IRequestRepo getAllRequest();
        IRequestRepo getRequestById(int request_id);
    }
}