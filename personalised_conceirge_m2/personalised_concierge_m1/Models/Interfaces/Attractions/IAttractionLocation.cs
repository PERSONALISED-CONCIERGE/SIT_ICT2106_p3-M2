namespace personalised_concierge_m1.Models.Interfaces.Attraction
{
    public interface IAttractionLocation
    {
        IAttractionLocation getAttractionLocationByAddress(string address);

    }
}