using System.Collections.Generic;
using personalised_concierge_m1.Models.Entities.Itineraries;

namespace personalised_concierge_m1.Models.Interfaces.Itineraries
{
    public interface IBudgetRepo : IGenericRepo<Budget>
    {
        //Budget Entity
        double findBudgetLimit(int id);
        void updateBudgetLimit(Budget budget);
        List<Expenses> findAllExpenses(int id);
        int findMaxExpensesId();
        void addExpenses(Expenses exp);
        void deleteExpenses(int id);
    }
}
