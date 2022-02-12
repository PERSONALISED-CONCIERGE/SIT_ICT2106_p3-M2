using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using personalised_concierge_m1.Models.Entities.UserDetails;

namespace personalised_concierge_m1.Models.Entities.RoomDetails
{
    public class Reservation
    {
        [Key]
        public int reservation_id { get; set; }
        public int account_id { get; set; }

        [ForeignKey("account_id")]
        public Account Account { get; set; }
        public int room_id { get; set; }

        [ForeignKey("room_id")]
        public Room Room { get; set; }

        [Required]
        public DateTime start_date { get; set; }

        [Required]
        public DateTime end_date { get; set; }
    }
}