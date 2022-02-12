using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Models.Interfaces.Itineraries;

namespace personalised_concierge_m1.Data.Itineraries
{
    public class ChecklistRepo : GenericRepo<Checklist>, IChecklistRepo
    {
        public ChecklistRepo(ConciergeContext context) : base(context)
        {
        }
        public IChecklistRepo getAllChecklists()
        {
            throw new System.NotImplementedException();
        }
        public IChecklistRepo getChecklistById(int checklist_id)
        {
            throw new System.NotImplementedException();
        }
    }
}
