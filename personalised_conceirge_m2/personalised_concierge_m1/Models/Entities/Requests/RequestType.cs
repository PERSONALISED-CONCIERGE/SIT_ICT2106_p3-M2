using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personalised_concierge_m1.Models.Entities.Requests
{
    public class RequestType
    {
        //table columns and properties
        [Key]
        public int requesttype_id { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(100)")]
        public string type_value { get; set; }
        public bool is_deleted { get; set; }
        [Required]
        public DateTime created_at { get; set; }
        public DateTime deleted_at { get; set; }
    }
}