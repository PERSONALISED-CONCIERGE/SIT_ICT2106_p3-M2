using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Entities.Itineraries
{
    public class Blog
    {
        [Key]
        public int blog_id { get; set; }
        public int account_id { get; set; }

        [ForeignKey("account_id")]
        public Account Account { get; set; }
        public int itinerary_id { get; set; }

        [ForeignKey("itinerary_id")]
        public Itinerary Itinerary { get; set; }
        public int foodleisure_id { get; set; }

        [ForeignKey("foodleisure_id")]
        public FoodLeisure FoodLeisure { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string name { get; set; }

        [Required]
        [Column(TypeName = "varchar(500)")]
        public string description { get; set; }

        [Required]
        public DateTime created_date { get; set; }
    }
}
