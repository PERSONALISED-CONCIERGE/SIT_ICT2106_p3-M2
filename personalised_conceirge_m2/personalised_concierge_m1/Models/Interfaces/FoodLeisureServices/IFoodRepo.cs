using personalised_concierge_m1.Models.Entities.FoodLeisureServices;

namespace personalised_concierge_m1.Models.Interfaces.FoodLeisureServices
{
    public interface IFoodRepo : IGenericRepo<Food>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        IFoodRepo getAllFoods();
        IFoodRepo getFoodById(int foodleisure_id);   
    }
}