using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public class FoodDelivery
    {
        //table columns and properties
        [Key]
        public int food_order_id { get; set; }

        public int account_id { get; set; }
        
        [ForeignKey("account_id")]
        public Account Account { get; set; }
        
        [Required]
        public int room_no { get; set; }
        [Column(TypeName = "varchar(200)")]
        public string instruction { get; set; }
    }
}