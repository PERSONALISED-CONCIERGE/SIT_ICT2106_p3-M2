using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;


namespace personalised_concierge_m1.Models.Entities.Itineraries
{
    public class Checklist
    {
        [Key]
        public int checklist_id { get; set; }
        public int itinerary_id { get; set; }

        [ForeignKey("itinerary_id")]
        public Itinerary Itinerary { get; set; }

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
