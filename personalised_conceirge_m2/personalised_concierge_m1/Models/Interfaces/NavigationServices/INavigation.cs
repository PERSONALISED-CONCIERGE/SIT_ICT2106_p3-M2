using System.Collections.Generic;
using personalised_concierge_m1.Models.Entities.Navigation;
using System.Linq;

namespace personalised_concierge_m1.Models.Interfaces.NavigationServices
{
    public interface INavigation : IGenericRepo<Navigation>
    {
        Navigation GetDistance(string endPoint);
    }
}
