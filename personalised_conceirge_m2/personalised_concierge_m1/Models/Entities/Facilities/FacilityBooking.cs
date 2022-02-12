using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Entities.Facilities
{
    public class FacilityBooking
    {
        [Key]
        public int facilitybooking_id { get; set; }
        
        //facility_id FK referencing the PK from Facility
        public int facility_id { get; set; }
        [ForeignKey("facility_id")]
        public Facility Facility { get; set; }
        
        //account_id FK referencing the PK from Account
        public int account_id { get; set; }
        [ForeignKey("account_id")]
        public Account Account { get; set; }
        
        [Required]
        public DateTime booking_start { get; set; }
        
        [Required]
        public DateTime booking_end { get; set; }
    }
}