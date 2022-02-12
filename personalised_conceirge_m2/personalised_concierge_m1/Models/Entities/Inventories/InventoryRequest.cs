using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personalised_concierge_m1.Models.Entities.Inventories
{
    public class InventoryRequest
    {
        [Key]
        public int invreq_id { get; set; }
        
        //inventory_id FK referencing the PK from InventoryCategory
        public int inventory_id { get; set; }
        [ForeignKey("inventory_id")]
        public Inventory Inventory { get; set; }
        
        [Required]
        public int quantity { get; set; }
        
        [Required]
        public int status_id { get; set; }
        
        [Required]
        public int price { get; set; }
        
        [Column(TypeName = "varchar(200)")]
        public string remarks { get; set; }
        
        [Required]
        public DateTime created_date { get; set; }
        
        public DateTime updated_date { get; set; }
    }
}