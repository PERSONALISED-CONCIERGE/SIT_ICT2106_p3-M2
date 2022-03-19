using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace personalised_concierge_m1.Models.Entities.Itineraries
{
    public class Expenses
    {
        [Column("ExpensesId")]
        [Key]
        private int expensesId { get; set; }

        [Column("UserId")]
        private int userId { get; set; }

        [Column("Currency")]
        private string currency { get; set; }

        [Column("Category")]
        private string category { get; set; }

        [Column("Amount")]
        private double amount { get; set; }

        [Column("Description")]
        private string description { get; set; }

        public int ExpensesId
        {
            get { return expensesId; }
            set { expensesId = value; }
        }

        public int UserId
        {
            get { return userId; }
            set { userId = value; }
        }
        public string Currency
        {
            get { return currency; }
            set { currency = value; }
        }
        public string Category
        {
            get { return category; }
            set { category = value; }
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}
