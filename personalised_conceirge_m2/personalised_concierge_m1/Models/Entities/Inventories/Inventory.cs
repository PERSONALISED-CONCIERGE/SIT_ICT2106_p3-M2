using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personalised_concierge_m1.Models.Entities.Inventories
{
    public class Inventory
    {
        [Key]
        public int inventory_id { get; set; }
        
        //invcate_id FK referencing the PK from InventoryCategory
        public int invcate_id { get; set; }
        [ForeignKey("invcate_id")]
        public InventoryCategory InventoryCategory { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string inv_name { get; set; }
        
        [Required]
        public int quantity { get; set; }
        
        [Required]
        [Column(TypeName = "varchar(50)")]
        public string status { get; set; }
    }
}                                     