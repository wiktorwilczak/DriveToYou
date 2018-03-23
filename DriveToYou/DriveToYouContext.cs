using DriveToYou.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DriveToYou
{
    public class DriveToYouContext : DbContext
    {
        public DriveToYouContext() : base("name=dbConnectionString")
        {

        }

        public DbSet<Track> Tracks { get; set; }

    }
}
