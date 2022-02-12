using personalised_concierge_m1.Models.Entities.OtherServices;
using personalised_concierge_m1.Models.Interfaces.OtherServices;

namespace personalised_concierge_m1.Data.OtherServices
{
    public class NavigationRepo:GenericRepo<Navigation>,INavigationRepo
    {
        public NavigationRepo(ConciergeContext context) : base(context)
        {
        }
        
        //implementation of non-generic interface methods
        public INavigationRepo getAllNavigations()
        {
            throw new System.NotImplementedException();
        }
        
        public INavigationRepo getNavigationById(int navigation_id)
        {
            throw new System.NotImplementedException();
        }
    }
}