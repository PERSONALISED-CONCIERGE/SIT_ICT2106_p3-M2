using personalised_concierge_m1.Models.Entities.OtherServices;

namespace personalised_concierge_m1.Models.Interfaces.OtherServices
{
    public interface ITransportationRepo:IGenericRepo<Transportation>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        ITransportationRepo getAllTransportations();
        ITransportationRepo getTransportationById(int transport_id);
    }
}