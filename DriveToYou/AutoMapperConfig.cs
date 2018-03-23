using AutoMapper;
using DriveToYou.DTO;
using DriveToYou.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveToYou
{
    public class AutoMapperConfig
    {
        public static void Initialize()
        {

            Mapper.Initialize((config) =>
            {
                config.CreateMap<Track, DailyReportDTO>()

               .ForMember(dest => dest.TotalPrice, opt => opt.MapFrom(src => (src.Price)))
               .ForMember(dest => dest.TotalDistance, opt => opt.MapFrom(src => (src.Distance.RemovingKmSuffix())));
                             

                config.CreateMap<Track, MonthlyReportDTO>()
                .ForMember(dest => dest.Date, opt => opt.MapFrom(src => src.Date))
                .ForMember(dest => dest.TotalDailyDistance, opt => opt.MapFrom(src => src.Distance.RemovingKmSuffix()))
                .ForMember(dest => dest.AverageDistance, opt => opt.MapFrom(src => src.Distance.RemovingKmSuffix()))
                .ForMember(dest => dest.AveragePrice, opt => opt.MapFrom(src => src.Price));
                
            });



        }
    }

   
}

