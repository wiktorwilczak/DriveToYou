using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveToYou.Models
{
    public class Track
    {
        [Key]
        public int ID { get; set; }
        public string Source_address { get; set; }
        public string Destination_address { get; set; }
        public decimal Price { get; set; }
        public DateTime Date { get; set; }
        public double Distance { get; set; }
    }
}
