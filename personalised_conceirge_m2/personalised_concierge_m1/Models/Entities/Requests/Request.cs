using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personalised_concierge_m1.Models.Entities.Requests
{
    public class Request
    {
        //table columns and properties
        [Key]
        public int request_id { get; set; }
        
        [Required]
        public int requesttype_id { get; set; }
        [ForeignKey("requesttype_id")]
        public RequestType RequestType { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(500)")]
        public string request_msg { get; set; }
    }
}