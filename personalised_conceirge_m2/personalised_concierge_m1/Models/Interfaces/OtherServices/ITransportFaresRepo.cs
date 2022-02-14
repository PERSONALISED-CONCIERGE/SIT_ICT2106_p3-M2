using personalised_concierge_m1.Models.Entities.OtherServices;

namespace personalised_concierge_m1.Models.Interfaces.OtherServices
{
    public interface ITransportFaresRepo : IGenericRepo<TransportFares>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        ITransportFaresRepo getAllTransportFares();

        ITransportFaresRepo getTransportFaresRepoById(int fare_id);

    }
}