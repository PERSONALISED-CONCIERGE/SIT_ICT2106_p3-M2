using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

    namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public enum TaxiType
    {
        Standard,
        Limo,
        Chrylsler,
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
        [Column(TypeName = "varchar(500)")]
        public string fare_name { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string fares { get; set; }

        [Required]
        public TaxiType type { get; set; }

    }
}
