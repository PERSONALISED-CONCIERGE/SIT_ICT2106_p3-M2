using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using personalised_concierge_m1.Models;

namespace personalised_concierge_m1.Models
{
    public class AttractionDemo
    {
        [Column("AttractionDemoId")]
        [Key]
        private int attractionDemoId { get; set; }

        [Column("Name")]
        private string name { get; set; }

        [Column("Location")]
        private string location { get; set; }

        [Column("Description")]
        private string description { get; set; }

        public int AttractionDemoId
        {
            get { return attractionDemoId; }
            set { attractionDemoId = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Location
        {
            get { return location; }
            set { location = value; }
        }
        public string Description
        {
            get { return description; }
            set { description = value; }
        }
    }
}