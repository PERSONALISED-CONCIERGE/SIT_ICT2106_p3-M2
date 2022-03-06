using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace personalised_concierge_m1.Models.Entities.FoodLeisureServices
{
    public enum FoodLeisureType
    {
        Restaurant,
        Hawker,
        POI,
        HotelFacilities
    }

    public class FoodLeisure
    {
        [Key]
        public int foodleisure_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string name { get; set; }

        [Required]
        [Column(TypeName = "varchar(500)")] 
        public string description { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string website_link { get; set; }

        [Required]
        [Column(TypeName = "varchar(20)")]
        public string contact_num { get; set; }

        [Required]
        public FoodLeisureType type { get; set; }

        [Required]
        [Column(TypeName = "varchar(500)")]
        public string address { get; set; }

        [Required]
        [Column(TypeName = "boolean")]
        public Boolean featured { get; set; }


    }
}