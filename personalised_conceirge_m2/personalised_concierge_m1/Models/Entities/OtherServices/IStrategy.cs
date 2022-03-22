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
        IEnumerable<Review> SortASC(int FoodLeisureID);
        IEnumerable<Review> SortDSC(int FoodLeisureID);
        IEnumerable<Review> Search(int FoodLeisureID, string searchstr);
    }
}