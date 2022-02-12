using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace personalised_concierge_m1.Models.Entities.Inventories
{
    public class InventoryCategory
    {
        [Key] public int invcate_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(50)")]
        public string cate_name { get; set; }
    }
}