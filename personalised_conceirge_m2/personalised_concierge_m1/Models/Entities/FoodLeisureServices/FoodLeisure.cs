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

        [Column(TypeName = "varchar(500)")]
        public string foodleisure_image { get; set; }

        [Required]
        public FoodLeisureType type { get; set; }

        [Required]
        [Column(TypeName = "varchar(500)")]
        public string address { get; set; }


        [Required]
        [Column(TypeName = "boolean")]
        public Boolean featured { get; set; }


        [Column(TypeName = "varchar(100)")]
        public string businessHours1 { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string businessHours2 { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string businessHours3 { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string businessHours4 { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string businessHours5 { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string businessHours6 { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string businessHours7 { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string latitude { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string longtitude { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string email { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string supportedLanguage { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string nearestMRTStation { get; set; }

    }
}