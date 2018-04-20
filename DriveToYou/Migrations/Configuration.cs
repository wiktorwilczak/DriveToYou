namespace DriveToYou.Migrations
{
    using DriveToYou.Models;
    using Newtonsoft.Json;
    using Newtonsoft.Json.Linq;
    using RestSharp;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using System.Web;

    internal sealed class Configuration : DbMigrationsConfiguration<DriveToYou.DriveToYouContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DriveToYou.DriveToYouContext context)
        {





            //var trackToSaveOne = new Track() { Source_address = "Sikorskiego 37, Wo³omin", Destination_address = "Poznañ", Date = new DateTime(2007, 3, 18), Price = 54 };
            var trackToSaveTwo = new Track() { Source_address = "Warszawa", Destination_address = "Gdynia", Date = new DateTime(2015, 3, 18), Price = 99, Distance = 444, EstimatedFuelCost = 23, EstimatedTime = "32" };
           var trackToSaveThree = new Track() { Source_address = "Katowice", Destination_address = "Łódź", Date = new DateTime(2016, 3, 18), Price = 524, Distance = 444.4, EstimatedFuelCost = 424, EstimatedTime = "52" };
            //var trackToSaveFourth = new Track() { Source_address = "Zakopane", Destination_address = "Szczecin", Date = new DateTime(2018, 3, 18), Price = 154};

            //context.Tracks.Add(trackToSaveOne);           
            context.Tracks.Add(trackToSaveTwo);
            context.Tracks.Add(trackToSaveThree);
            //context.Tracks.Add(trackToSaveFourth);

            context.SaveChanges();
        }
    }
}
