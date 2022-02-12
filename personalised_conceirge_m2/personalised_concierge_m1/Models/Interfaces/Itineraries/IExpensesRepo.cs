using personalised_concierge_m1.Models.Entities.Itineraries;


namespace personalised_concierge_m1.Models.Interfaces.Itineraries
{
    public interface IExpensesRepo : IGenericRepo<Expenses>
    {
        IExpensesRepo getAllExpenses();
        IExpensesRepo getExpensesById(int expenses_id);
    }
}
