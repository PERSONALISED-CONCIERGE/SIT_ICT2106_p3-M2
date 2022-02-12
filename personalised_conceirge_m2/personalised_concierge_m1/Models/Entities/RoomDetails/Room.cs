using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personalised_concierge_m1.Models.Entities.RoomDetails
{
    public class Room
    {
        //The Entity data to be used. EF will then create table according the the Class Name and columns with the variable names.
        [Key]
        public int room_id { get; set; }
        public int roomType_id { get; set; }

        [ForeignKey("roomType_id")]
        public RoomType RoomType { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string room_num { get; set; }

        [Required]
        public bool vacancy { get; set; }
    }
}