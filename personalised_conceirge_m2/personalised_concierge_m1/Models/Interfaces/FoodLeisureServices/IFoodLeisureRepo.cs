using personalised_concierge_m1.Models.Entities.FoodLeisureServices;

namespace personalised_concierge_m1.Models.Interfaces.FoodLeisureServices
{
    public interface IFoodLeisureRepo : IGenericRepo<FoodLeisure>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        IFoodLeisureRepo getAllFoodLeisure();
        IFoodLeisureRepo getFoodLeisureById(int foodleisure_id);   
    }
}