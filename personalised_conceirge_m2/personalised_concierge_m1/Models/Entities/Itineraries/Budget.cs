using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;


namespace personalised_concierge_m1.Models.Entities.Itineraries
{
    public class ExpensesList
    {
        public List<Expenses> Expenses { get; set; }
    }
    public class Budget
    {
        [Key]
        public int budget_id{ get; set; }

        [ForeignKey("itinerary_id")]
        public int itinerary_id { get; set; }
        
        [ForeignKey("itinerary_id")]
        public Itinerary Itinerary { get; set; }

        [Required]
        public double budget_estimate { get; set; }

        //[Required]
        //public List<Expenses> list_of_expenses { get; set; } 
    }
}
