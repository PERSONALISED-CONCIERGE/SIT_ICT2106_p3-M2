namespace personalised_concierge_m1.Models.Interfaces.Attraction
{
    public interface IAttraction
    {
        IAttraction getAttractionById(int id);
        IAttraction getAttractionByName(string name);
        IAttraction getAttractionByPrice(double price);

    }
}