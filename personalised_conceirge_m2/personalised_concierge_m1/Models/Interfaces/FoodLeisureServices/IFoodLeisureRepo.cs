using System.Threading.Tasks;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;


namespace personalised_concierge_m1.Models.Interfaces.FoodLeisureServices
{
    public interface IFoodLeisureRepo : IGenericRepo<FoodLeisure>
    {
        IFoodLeisureRepo getFooDLeisureByID(int foodleisure_id);

        IFoodLeisureRepo getFeaturedFooDLeisure();
    }
}