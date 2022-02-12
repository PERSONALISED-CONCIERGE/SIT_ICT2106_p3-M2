using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace personalised_concierge_m1.Models.Entities.FoodLeisureServices
{
    public class Attraction
    {
        [Key]
        public int foodleisure_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string attraction_hours { get; set; }

        [Required]
        public double attraction_lat { get; set; }

        [Required]
        public double attraction_lon { get; set; }

        [Required]
        public double attraction_price { get; set; }
    }
}