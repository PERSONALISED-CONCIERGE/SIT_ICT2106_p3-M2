using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;

namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public enum NavigationType
    {
        Walk, Drive, Car, Taxi, Train, Bus
    }
    
    //table columns and properties
    public class Navigation
    {
        [Key]
        public int navigation_id { get; set; }

        [Required]

        public int foodleisure_id { get; set; }

        [ForeignKey("foodleisure_id")]
        public FoodLeisure FoodLeisure { get; set; }
        
        [Required]
        public double start_lon { get; set; }
        [Required]
        public double end_lon { get; set; }
        [Required]
        public double start_lat { get; set; }
        [Required]
        public double end_lat { get; set; }
        [Required]
        public int duration { get; set; }
        [Required]
        public int distance { get; set; }
        [Required]
        public NavigationType type { get; set; }
    }
}