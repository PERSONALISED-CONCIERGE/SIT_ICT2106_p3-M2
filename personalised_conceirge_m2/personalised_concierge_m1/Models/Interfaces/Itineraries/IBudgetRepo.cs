using personalised_concierge_m1.Models.Entities.Itineraries;

namespace personalised_concierge_m1.Models.Interfaces.Itineraries
{
    public interface IBudgetRepo : IGenericRepo<Budget>
    {
        IBudgetRepo getAllBudgets();
        IBudgetRepo getBudgetById(int budget_id);
    }
}
