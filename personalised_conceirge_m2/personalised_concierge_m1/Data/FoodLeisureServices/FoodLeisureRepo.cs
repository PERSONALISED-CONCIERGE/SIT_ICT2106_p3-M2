using System.Collections.Generic;
using System.Linq;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using personalised_concierge_m1.Models.Interfaces.FoodLeisureServices;

namespace personalised_concierge_m1.Data.FoodLeisureServices
{

    public class FoodLeisureRepo : GenericRepo<FoodLeisure>, IFoodLeisureRepo
    {
        public FoodLeisureRepo(ConciergeContext context) : base(context)
        {
        }

        public FoodLeisure GetFoodLeisureByID(int foodleisure_id)
        {
            return _context.Set<FoodLeisure>().Find(foodleisure_id);
        }

        public IEnumerable<FoodLeisure> GetAllFoodLeisure()
        {
            return _context.Set<FoodLeisure>().ToList();
        }

        public void UpdateFeatured(FoodLeisure foodLeisure)
        {
            _context.FoodLeisures.Attach(foodLeisure).Property(foodLeisure => foodLeisure.featured).IsModified = true;
            _context.SaveChanges();
        }

        public IEnumerable<FoodLeisure> GetFeaturedFoodLeisure(bool featured)
        {
            return _context.FoodLeisures.Where(FoodLeisure => FoodLeisure.featured == featured).ToList();
        }

        public FoodLeisure GetFoodLeisureByName(string name)
        {
            return _context.Set<FoodLeisure>().First(FoodLeisure => FoodLeisure.name == name); 
        }

        public IEnumerable<FoodLeisure> GetLimitedFoodLeisureBytype(FoodLeisureType foodleisuretype)
        {
            return _context.FoodLeisures.Where(FoodLeisure => FoodLeisure.type == foodleisuretype).OrderBy(FoodLeisure => FoodLeisure.foodleisure_id).Take(100).ToList();
        }

    }
}