using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveToYou.DTO
{
    public class DailyReportDTO
    {
        public decimal TotalDistance { get; set; }
        public decimal TotalPrice { get; set; }
        public int DrivesCount { get; set; }
    }
}
