using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using personalised_concierge_m1.Models.Interfaces.FoodLeisureServices;

namespace personalised_concierge_m1.Data.FoodLeisureServices
{
    public class FoodLeisureRepo : GenericRepo<FoodLeisure>, IFoodLeisureRepo
    {
        public FoodLeisureRepo(ConciergeContext context) : base(context)
        {
        }
        public IFoodLeisureRepo getAllFoodLeisure()
        {
            throw new System.NotImplementedException();
        }
        public IFoodLeisureRepo getFoodLeisureById(int room_Id)
        {
            throw new System.NotImplementedException();
        }
    }
}