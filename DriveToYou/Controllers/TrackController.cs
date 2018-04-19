using DriveToYou.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using DriveToYou.Services;
using DriveToYou.Interfaces;

namespace DriveToYou.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [System.Web.Http.RoutePrefix("transits")]
    public class TrackController : ApiController
    {

        private readonly ITrackService _trackService;
        private readonly DriveToYouContext _dbContext;
        

        public TrackController(ITrackService trackService, DriveToYouContext dbContext)
        {
            _trackService = trackService;
            _dbContext = dbContext;
        }


        [System.Web.Http.HttpPost]
        [System.Web.Http.Route("AddTrack")]
        public void AddTrack ([FromBody]Track track)
        {
          
            _trackService.AddTrack(track);
        }


        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("reports/daily/{startdate}/{enddate}")]
        public IHttpActionResult GetDailyReport(DateTime startdate, DateTime enddate)
        {
            return Ok(_trackService.GetDailyReport(startdate, enddate));        

        }

        [System.Web.Http.HttpGet]
        [System.Web.Http.Route("reports/monthly/{monthNumber}")]
        public IHttpActionResult GetMonthlyReport(int monthNumber)
        {
            return Ok(_trackService.GetMonthlyReport(monthNumber));

        }


    }
}
