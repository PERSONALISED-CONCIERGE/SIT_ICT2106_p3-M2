using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public enum FaresType
    {
        Standard,
        Flagdown,
        Distance
    }
    public class TransportFares
    {
        //table columns and properties
        [Key]
        public int fare_id { get; set; }
        [Required]
        public int transport_id { get; set; }
        [ForeignKey("transport_id")]
        public Transportation Transportation { get; set; }

        [Required]
        public FaresType fares_type { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string fares { get; set; }

    }
}
