using System.Collections.Generic;

namespace personalised_concierge_m1.Models.Entities.OtherServices
{

    // The Strategy interface declares operations common to all supported
    // versions of some algorithm.
    //
    // The Context uses this interface to call the algorithm defined by Concrete
    // Strategies.
    public interface IStrategy
    {
        IEnumerable<Review> SortASC(object data);
        IEnumerable<Review> SortDSC(object data);
    }
}