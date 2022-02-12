using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace personalised_concierge_m1.Models.Entities.Itineraries
{
    public class Expenses
    {
        [Key]
        public int expenses_id { get; set; }
        public int budget_id { get; set; }

        [ForeignKey("budget_id")]
        public Budget Budget { get; set; }

        [Required]
        public double cost { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string category { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string description { get; set; }
    }
}
