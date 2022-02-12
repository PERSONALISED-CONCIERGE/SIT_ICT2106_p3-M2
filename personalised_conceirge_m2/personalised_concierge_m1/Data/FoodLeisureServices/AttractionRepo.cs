using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using personalised_concierge_m1.Models.Interfaces.FoodLeisureServices;

namespace personalised_concierge_m1.Data.FoodLeisureServices
{
    public class AttractionRepo : GenericRepo<Attraction>, IAttractionRepo
    {
        public AttractionRepo(ConciergeContext context) : base(context)
        {
        }
        public IAttractionRepo getAllAttractions()
        {
            throw new System.NotImplementedException();
        }
        public IAttractionRepo getAttractionById(int foodleisure_id)
        {
            throw new System.NotImplementedException();
        }
    }
}