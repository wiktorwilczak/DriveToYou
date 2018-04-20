using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DriveToYou.DTO
{
    public class TrackReport
    {
        public double Distance { get; set; }
        public string EstimatedTime { get; set; }
        public double EstimatedFuelCost { get; set; }
    }
}