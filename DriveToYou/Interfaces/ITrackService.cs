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
        TrackReport GetTrackReport(string Source_address, string Destination_address);
        DailyReportDTO GetDailyReport(DateTime startdate, DateTime enddate);
        List<MonthlyReportDTO> GetMonthlyReport(int monthNumber);
        List<Track> UpcomingTracks();
        
    }
}
