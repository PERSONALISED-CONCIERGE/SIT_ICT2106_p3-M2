using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace personalised_concierge_m1.Models.Entities.FoodLeisureServices
{
    public enum CuisineType
    {
        Malay,
        Chinese,
        Indian,
        Western
    }
    public class Food
    {
        [Key]
        public int foodleisure_id { get; set; }

        [Required]
        public CuisineType cuisine { get; set; }
    }
}