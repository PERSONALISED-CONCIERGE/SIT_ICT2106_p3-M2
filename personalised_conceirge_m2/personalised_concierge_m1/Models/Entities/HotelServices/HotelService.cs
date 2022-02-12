using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;
using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Entities.HotelServices
{
    public class HotelService
    {
        [Key]
        public int service_id { get; set; }
        public int account_id { get; set; }

        [ForeignKey("account_id")]
        public Account Account { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string description { get; set; }

        [Required]
        public bool availability { get; set; }         
    }
}