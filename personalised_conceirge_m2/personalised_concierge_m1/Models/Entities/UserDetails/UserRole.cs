using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.VisualBasic;

namespace personalised_concierge_m1.Models.Entities.UserDetails
{
    public class UserRole
    {
        [Key]
        public int role_id { get; set; }

        [Required]
        [Column(TypeName = "varchar(100)")]
        public string role { get; set; }
    }
}