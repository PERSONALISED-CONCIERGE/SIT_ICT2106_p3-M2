using System;

namespace personalised_concierge_m1.Models.Entities.Navigation
{
    public interface INavigation
    {
        public Navigation getDistance(string endPoint);
    }
}
