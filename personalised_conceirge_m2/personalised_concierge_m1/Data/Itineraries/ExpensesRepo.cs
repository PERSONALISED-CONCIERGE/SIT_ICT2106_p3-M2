using System.Linq;
using Microsoft.EntityFrameworkCore;
using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Models.Interfaces.Itineraries;

namespace personalised_concierge_m1.Data.Itineraries
{
    public class ExpensesRepo : GenericRepo<Expenses>, IExpensesRepo
    {
        public ExpensesRepo(ConciergeContext context) : base(context)
        {
        }
        public IExpensesRepo getAllExpenses()
        {
            throw new System.NotImplementedException();
        }
        public IExpensesRepo getExpensesById(int expenses_id)
        {
            throw new System.NotImplementedException();
        }
    }
}
