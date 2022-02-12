using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace personalised_concierge_m1.Models.Entities.RoomDetails
{
    public class RoomType
    {
        [Key]
        public int roomtype_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string room_type { get; set; }

        [Required]
        [Column(TypeName = "varchar(800)")]
        public string description { get; set; }

        [Required]
        public decimal price { get; set; }        
    }
}