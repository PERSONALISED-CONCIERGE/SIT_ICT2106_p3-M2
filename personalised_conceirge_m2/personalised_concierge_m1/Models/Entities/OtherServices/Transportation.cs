using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public enum TransportationType
    {
        Taxi,Limo,Car_sharing,Radio_taxi,Bus_charter
    }

    public class Transportation
    {
        //table columns and properties
        [Key] 
        public int transport_id { get; set; }
        [Required]
        public int account_id { get; set; }
        [ForeignKey("account_id")]
        public Account Account { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string name { get; set; }
        
        [Column(TypeName = "varchar(500)")]
        public string description { get; set; }
        [Column(TypeName = "varchar(500)")]
        public string website { get; set; }
        [Required]
        [MaxLength(8)]
        public int contact_num { get; set; }
        [Required]
        public TransportationType type { get; }

    }
}