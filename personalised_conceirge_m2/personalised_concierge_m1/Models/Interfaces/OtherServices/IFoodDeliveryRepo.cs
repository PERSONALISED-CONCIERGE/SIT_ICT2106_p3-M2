using personalised_concierge_m1.Models.Entities.OtherServices;
using personalised_concierge_m1.Models.Interfaces.OtherServices;
namespace personalised_concierge_m1.Models.Interfaces.OtherServices
{ 
    public interface IFoodDeliveryRepo:IGenericRepo<FoodDelivery>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        IFoodDeliveryRepo getAllFoodDelivery();
        IFoodDeliveryRepo getFoodDeliveryById(int food_order_id);
    }
}