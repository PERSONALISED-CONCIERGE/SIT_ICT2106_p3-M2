using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;
using personalised_concierge_m1.Models.Entities.UserDetails;
namespace personalised_concierge_m1.Models.Entities.Attraction
{
    public class Attraction
    {

        [Key]
        public int attraction_id { get; set; }

        [Required]
        public string attraction_name { get; set; }

        [Required]
        public string attraction_dist { get; set; }

        [Required]
        public string attraction_location { get; set; }


    }
}
