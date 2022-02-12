using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;

namespace personalised_concierge_m1.Models.Entities.Itineraries
{
    public class ItineraryItem
    {
        [Key]
        public int itinerary_item_id { get; set; }
        public int foodleisure_id { get; set; }

        [ForeignKey("foodleisure_id")]
        public FoodLeisure FoodLeisure { get; set; }
        public int itinerary_id { get; set; }

        [ForeignKey("itinerary_id")]
        public Itinerary Itinerary { get; set; }

        [Required]
        public int sequence { get; set; }
    }
}
