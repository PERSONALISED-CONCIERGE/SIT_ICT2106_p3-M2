using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using personalised_concierge_m1.Models.Interfaces.FoodLeisureServices;
using System.Linq;
using System.Collections.Generic;

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

        public IEnumerable<FoodLeisure> UpdateFeatured(FoodLeisure foodLeisure)
        {
            return _context.FoodLeisures.(Entry(foodLeisure).Property("featured").IsModified = true).SaveChanges();
        }
    }
}