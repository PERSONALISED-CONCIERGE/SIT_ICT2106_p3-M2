using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Entities.Requests
{
    public class GuestRequest
    {
        //table columns and properties
        [Required]
        public int account_id { get; set; }
        [ForeignKey("account_id")]
        public Account Account { get; set; }
        
        [Required]
        public int request_id { get; set; }
        [ForeignKey("request_id")]
        public Request Request { get; set; }
        
        [Required]
        public int serviced_by { get; set; }
        [ForeignKey("serviced_by")]
        public Account ServicedBy { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string status { get; set; }
        [Required]
        public bool is_deleted { get; set; }
        
        [Required]
        public DateTime created_at { get; set; }
        public DateTime deleted_at { get; set; }
        public DateTime serviced_at { get; set; }
    }
}