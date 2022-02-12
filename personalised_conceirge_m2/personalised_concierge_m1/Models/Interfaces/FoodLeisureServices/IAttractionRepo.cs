using personalised_concierge_m1.Models.Entities.FoodLeisureServices;

namespace personalised_concierge_m1.Models.Interfaces.FoodLeisureServices
{
    public interface IAttractionRepo : IGenericRepo<Attraction>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        IAttractionRepo getAllAttractions();
        IAttractionRepo getAttractionById(int foodleisure_id);   
    }
}