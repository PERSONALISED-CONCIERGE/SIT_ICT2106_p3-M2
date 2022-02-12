using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace personalised_concierge_m1.Models.Entities.Facilities
{
    public class Facility
    {
        [Key]
        public int facility_id { get; set; }
        
        //[ForeignKey("hotel_id")] need to ask about this, wait for further implemenntations
        public int hotel_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string name { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string status { get; set; }
        
        [Required]
        public DateTime operation_start_time { get; set; }
        
        [Required]
        public DateTime operation_end_time { get; set; }
    }
}