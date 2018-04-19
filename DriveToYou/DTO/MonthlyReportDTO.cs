using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveToYou.DTO
{
    public class MonthlyReportDTO
    {
        public DateTime Date { get; set; }
        public decimal TotalDailyDistance { get; set; }
        public decimal AverageDistance { get; set; }
        public decimal AveragePrice { get; set; }
        public int DrivesCount { get; set; }
        public int ShortDate { get; set; }

    }
}
