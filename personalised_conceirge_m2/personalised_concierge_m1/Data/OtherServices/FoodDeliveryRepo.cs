using System;
using personalised_concierge_m1.Models.Entities.OtherServices;
using personalised_concierge_m1.Models.Interfaces.OtherServices;
namespace personalised_concierge_m1.Data.OtherServices
{
    public class FoodDeliveryRepo: GenericRepo<FoodDelivery>,IFoodDeliveryRepo
    {
        public FoodDeliveryRepo(ConciergeContext context) : base(context)
        {
        }

        //implementation of non-generic interface methods
        public IFoodDeliveryRepo getAllFoodDelivery()
        {
            throw new System.NotImplementedException();
        }

        public IFoodDeliveryRepo getFoodDeliveryById(int food_order_id)
        {
            throw new System.NotImplementedException();
        }
    }
}