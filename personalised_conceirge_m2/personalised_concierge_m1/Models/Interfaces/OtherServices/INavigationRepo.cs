using personalised_concierge_m1.Models.Entities.OtherServices;

namespace personalised_concierge_m1.Models.Interfaces.OtherServices
{
    public interface INavigationRepo:IGenericRepo<Navigation>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        INavigationRepo getAllNavigations(); 
        INavigationRepo getNavigationById(int navigation_id);
    }
}