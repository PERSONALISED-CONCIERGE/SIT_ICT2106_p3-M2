

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

        public IFoodLeisureRepo getFooDLeisureByID(int foodleisure_id)
        {
            throw new System.NotImplementedException();
        }


        public IEnumerable<FoodLeisure> GetLimitedFoodLeisureBytype(FoodLeisureType foodleisuretype)
        {
            return _context.FoodLeisures.Where(FoodLeisure => FoodLeisure.type == foodleisuretype).Take(100).ToList();
        }

    }
}