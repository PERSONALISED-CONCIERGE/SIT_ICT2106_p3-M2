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
        public int attractionId { get; set; }

        [Required]
        public string attractionName { get; set; }

        [Required]
        public string attractionImage { get; set; }

        [Required]
        public string attractionDescription { get; set; }

        [Required]
        public double attractionPrice { get; set; }

        [Required]

        public int attractionVote { get; set; }

        public string attraction_location { get; set; }



    }
}