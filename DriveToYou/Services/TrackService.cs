﻿using DriveToYou.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DriveToYou.Models;
using RestSharp;
using Newtonsoft.Json;
using DriveToYou.DTO;
using AutoMapper;

namespace DriveToYou.Services
{
    public class TrackService : ITrackService
    {
        private readonly DriveToYouContext _db;

        public TrackService(DriveToYouContext db)
        {
            _db = db;
        }

        public void AddTrack(Track track)
        {
            var client = new RestClient("https://maps.googleapis.com/maps/api/distancematrix/json");
            var request = new RestRequest(Method.GET);
            request.AddParameter("origins", track.Source_address);
            request.AddParameter("destinations", track.Destination_address);
            request.AddParameter("key", "AIzaSyA1RgvPAeRDK2rcaU0lDts9UUhbFB2y-xY");
            IRestResponse response = client.Execute(request);


            dynamic stuff = JsonConvert.DeserializeObject(response.Content);
            string dist = stuff.rows[0].elements[0].distance.text;
            //konwertowanie
            
            track.Distance = dist;
            _db.Tracks.Add(track);
            _db.SaveChanges();
        }

     

        public DailyReportDTO GetDailyReport(DateTime startdate, DateTime enddate)
        {
            var query = from days in _db.Tracks
                        where (days.Date >= startdate.Date && days.Date <= enddate)
                        select days;

          
            var querylist = new List<Track>();
            foreach (var item in query)
            {                
               
                querylist.Add(item);
            }

            var dataDTO = Mapper.Map<List<DailyReportDTO>>(querylist);
            

            var result = new DailyReportDTO()
            {
                TotalDistance = dataDTO.Sum(o => o.TotalDistance),
                TotalPrice = dataDTO.Sum(o => o.TotalPrice),
                DrivesCount = dataDTO.Count()
                
            };
            return result;
        }

        public IEnumerable <List<MonthlyReportDTO>> GetMonthlyReport()
        {

            var querycwj = _db.Tracks.Where(o => o.Date.Month == DateTime.Now.Month && o.Date.Year == DateTime.Now.Year)
                .GroupBy(u => u.Date.Day).ToList();
                    

            var query = from days in _db.Tracks
                        where (days.Date.Month == DateTime.Now.Month && days.Date.Year == DateTime.Now.Year)
                        select days;

            var querylist = new List<Track>();

            foreach (var item in query)
            {
                querylist.Add(item);
            }

            var dataDTO = Mapper.Map<List<MonthlyReportDTO>>(querylist);
         


            var groupedList = dataDTO
                  .GroupBy(u => u.Date.Day)
                  .Select(grp => grp.ToList())
                  .ToList();

            var tempList = new MonthlyReportDTO();           
            var finalList = new List<MonthlyReportDTO>();
          

            for (int i = 0; i < groupedList.Count; i++)
            {
                var TotalDailyDistance = groupedList[i].Sum(o => o.TotalDailyDistance);
                var AveragePrice = groupedList[i].Average(o => o.AveragePrice);
                var AverageDistance = groupedList[i].Average(o => o.AverageDistance);

                tempList.TotalDailyDistance = TotalDailyDistance;
                tempList.AveragePrice = AveragePrice;
                tempList.AverageDistance = AverageDistance;                              
            
                finalList.Add(tempList);
                yield return finalList;
                finalList.Clear();                
            }
       
        }



    }
}