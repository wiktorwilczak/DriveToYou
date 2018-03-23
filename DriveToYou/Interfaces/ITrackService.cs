using DriveToYou.DTO;
using DriveToYou.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveToYou.Interfaces
{
    public interface ITrackService
    {
        void AddTrack(Track track);
        DailyReportDTO GetDailyReport(DateTime startdate, DateTime enddate);
        IEnumerable<List<MonthlyReportDTO>> GetMonthlyReport();
    }
}
