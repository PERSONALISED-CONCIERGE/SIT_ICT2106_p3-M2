using System.Collections.Generic;
using personalised_concierge_m1.Models.Entities.Navigation;
using System.Linq;

namespace personalised_concierge_m1.Models.Interfaces.NavigationServices
{
    public interface INavigation : IGenericRepo<Navigation>
    {
        Navigation getModeOfTransport(string transport);
        Navigation setModeOfTransport(string transport);
        Navigation getDistance(string endPoint);
    }
}
