using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;
using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public enum Rating
    {
        One = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5
    }
    public class Review
    {
        //table columns and properties
        [Key]
        public int review_id { get; set; }
        [Required]
        public int account_id { get; set; }
        
        [ForeignKey("account_id")]
        public Account Account { get; set; }
        
        [Required]
        public int foodleisure_id { get; set; }
        
        [ForeignKey("foodleisure_id")]
        public FoodLeisure FoodLeisure { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string review  { get; set; }

        [DataType(DataType.Date)]
        public string Date { get; set; }

        public Rating rating { get; set; }


    }
}