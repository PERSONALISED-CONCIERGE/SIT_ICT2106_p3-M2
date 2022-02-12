using personalised_concierge_m1.Models.Entities.Itineraries;


namespace personalised_concierge_m1.Models.Interfaces.Itineraries
{
    public interface IChecklistRepo : IGenericRepo<Checklist>
    {
        IChecklistRepo getAllChecklists();
        IChecklistRepo getChecklistById(int checklist_id);
    }
}
