using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using personalised_concierge_m1.Models.Interfaces.FoodLeisureServices;

namespace personalised_concierge_m1.Data.FoodLeisureServices
{
    public class FoodRepo : GenericRepo<Food>, IFoodRepo
    {
        public FoodRepo(ConciergeContext context) : base(context)
        {
        }
        public IFoodRepo getAllFoods()
        {
            throw new System.NotImplementedException();
        }
        public IFoodRepo getFoodById(int foodleisure_id)
        {
            throw new System.NotImplementedException();
        }
    }
}