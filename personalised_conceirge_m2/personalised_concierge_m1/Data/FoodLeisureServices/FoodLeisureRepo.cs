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

        public void UpdateFeatured(FoodLeisure foodLeisure)
        {
            var foodLeisure_id = foodLeisure.foodleisure_id;
            _context.FoodLeisures.Attach(foodLeisure).Property(foodLeisure => foodLeisure.featured).IsModified = true;
            _context.SaveChanges();
        }

        public IEnumerable<FoodLeisure> GetFeaturedFoodLeisure(bool featured)
        {
            return _context.FoodLeisures.Where(FoodLeisure => FoodLeisure.featured == featured).ToList();
        }
    }
}