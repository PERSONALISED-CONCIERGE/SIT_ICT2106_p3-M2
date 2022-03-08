using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;
using personalised_concierge_m1.Models.Entities.Facilities;
using personalised_concierge_m1.Models.Entities.Requests;

namespace personalised_concierge_m1.Models.Entities.UserDetails
{
    public class Account
    {
        [Key]
        public int account_id { get; set; }
        public int role_id { get; set; }

        [ForeignKey("role_id")]
        public UserRole UserRole { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string guest_type { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string username { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string full_name { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string profile_pic { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string password_hash { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string access_key { get; set; }
        public int request_id { get; set; }

        [ForeignKey("request_id")]
        public Request Request { get; set; }
        public bool has_reservation { get; set; }
        public int reservation_id { get; set; }
        public int phone_number { get; set; }
        public bool phone_number_confirmed { get; set; }
        public bool two_factor_enabled { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string email { get; set; }
        public bool email_confirmed { get; set; }
        public int feedback_id { get; set; }

        // [ForeignKey("feedback_id")]
        // public Feedback Feedback { get; set; }

        [Column(TypeName = "varchar(500)")]
        public string location { get; set; }
        public decimal distance_from_hotel { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string currency { get; set; }
        public int facility_id { get; set; }

        [ForeignKey("facility_id")]
        public Facility Facility { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string position { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string secret_hashpin { get; set; }
    }
}