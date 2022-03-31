using System;
using System.Collections.Generic;
using System.Linq;
using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Models.Interfaces.Itineraries;

namespace personalised_concierge_m1.Data.Itineraries
{
    public class BudgetRepo : GenericRepo<Budget>, IBudgetRepo
    {
        private readonly ConciergeContext _context;
        public BudgetRepo(ConciergeContext context) : base(context)
        {
            _context = context;
        }

        public void addExpenses(Expenses exp)
        {
            _context.Add(exp);
            _context.SaveChanges();
        }

        public void deleteExpenses(int id)
        {
            var expenses = _context.Expenses.Find(id);
            _context.Expenses.Remove(expenses);
            _context.SaveChanges();
        }

        public List<Expenses> findAllExpenses(int id)
        {
            var expensesLocalList = _context.Expenses.Where(m => m.UserId == id).ToList();
            return expensesLocalList;
        }

        public double findBudgetLimit(int id)
        {
            double budgetLimit = 0;
            try
            {
                var budgetObj = _context.Budgets.First(m => m.Budgetid == id);
                budgetLimit = budgetObj.Budgetlimit;
            }
            catch (InvalidOperationException ex)
            {

            }
            return budgetLimit;
        }

        public int findMaxExpensesId()
        {
            int currentExpensesId;
            try
            {
                currentExpensesId = _context.Expenses.Max(m => m.ExpensesId);
            }
            catch (InvalidOperationException ex)
            {
                currentExpensesId = 0;
            }
            return currentExpensesId;
        }

        public void updateBudgetLimit(Budget budget)
        {
            Budget prodToUpdate = _context.Budgets.Where(p => p.Budgetid == budget.Budgetid).FirstOrDefault();
            if (prodToUpdate != null)
            {
                _context.Entry(prodToUpdate).CurrentValues.SetValues(budget);
                _context.SaveChanges();
            }
            else
            {
                _context.Add(budget);
                _context.SaveChanges();
            }
        }
    }
}
