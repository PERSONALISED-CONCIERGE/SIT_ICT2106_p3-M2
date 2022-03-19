using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;


namespace personalised_concierge_m1.Models.Entities.Itineraries
{
    public class Budget
    {
        [Column("Budgetid")]
        [Key]
        private int budgetid;

        [Column("Budgetlimit")]
        private double budgetlimit;

        [NotMapped]
        private List<Expenses> expensesList = new List<Expenses>();
        [NotMapped]
        private Expenses expenses;
        [NotMapped]
        private string currency = "SGD";
        [NotMapped]
        private double totalExpensesAmount = 0.00;
        [NotMapped]
        private int budgetRatio = 0;


        public int Budgetid
        {
            get { return budgetid; }
            set { budgetid = value; }
        }

        public double Budgetlimit
        {
            get { return budgetlimit; }
            set { budgetlimit = value; }
        }
        [NotMapped]
        public List<Expenses> ExpensesList
        {
            set { expensesList = value; }
            get { return expensesList; }
        }
        [NotMapped]
        public Expenses Expenses
        {
            set { expenses = value; }
            get { return expenses; }
        }
        [NotMapped]
        public string Currency
        {
            set { currency = value; }
            get { return currency; }
        }
        [NotMapped]
        public double TotalExpensesAmount
        {
            set { totalExpensesAmount = value; }
            get { return totalExpensesAmount; }
        }
        [NotMapped]
        public int BudgetRatio
        {
            set { budgetRatio = value; }
            get { return budgetRatio; }
        }
    }
}
