using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Models.Interfaces.Itineraries;

namespace personalised_concierge_m1.Data.Itineraries
{
    public class BudgetRepo : GenericRepo<Budget>, IBudgetRepo
    {
        public BudgetRepo(ConciergeContext context) : base(context)
        {
        }
        public IBudgetRepo getAllBudgets()
        {
            throw new System.NotImplementedException();
        }
        public IBudgetRepo getBudgetById(int budget_id)
        {
            throw new System.NotImplementedException();
        }
    }
}
