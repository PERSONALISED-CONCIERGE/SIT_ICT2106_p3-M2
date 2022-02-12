using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Entities.Facilities
{
    public class Feedback
    {
        [Key]
        public int feedback_id { get; set; }
        
        //FK account_id that is referencing PK of Account
        public int account_id { get; set; }
        [ForeignKey("account_id")]
        public Account Account { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string type { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string description { get; set; }
        
        [Required]
        public DateTime created_at { get; set; }
    }
}