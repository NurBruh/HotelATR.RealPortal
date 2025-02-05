using System.Drawing;
using System;

namespace HotelATR.RealPortal.Models
{

    public class TeamViewModel
    {
        //imgpath
        public string ImagePath { get; set; }
        //Billy Herrington
        public string FullName { get; set; }
        //(Bruh)
        public string Position { get; set; }
        //Bonjour messie slave.
        public string Description { get; set; }
        //Yapiiiiiiii
        public List<TeamLinks> TeamLinks { get; set; }
    }

    public class TeamLinks
    {
        public string URL { get; set; }

        public string LinkType { get; set; }
    }
}
