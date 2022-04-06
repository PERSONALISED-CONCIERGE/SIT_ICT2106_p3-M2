using System.Collections.Generic;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using System.Linq;



namespace personalised_concierge_m1.Models.Interfaces.FoodLeisureServices
{
    public interface IFoodLeisureRepo : IGenericRepo<FoodLeisure>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        FoodLeisure GetFoodLeisureByID(int foodleisure_id);
        IEnumerable<FoodLeisure> GetAllFoodLeisure();
        void UpdateFeatured(FoodLeisure foodLeisure);
        IEnumerable<FoodLeisure> GetFeaturedFoodLeisure(bool featured);
        FoodLeisure GetFoodLeisureByName(string name);
        IEnumerable<FoodLeisure> GetLimitedFoodLeisureBytype(FoodLeisureType foodleisuretype);
    }
}