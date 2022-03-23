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
        public decimal start_lon { get; set; }

        [Required]
        public decimal start_lat { get; set; }

        [Required]
        public decimal end_lon { get; set; }

        [Required]
        public decimal end_lat { get; set; }

        [Required]
        public decimal duration { get; set; }

        [Required]
        public decimal distance { get; set; }

        [Required]
        public int type { get; set; }


    }
}
