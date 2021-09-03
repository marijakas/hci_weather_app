using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    class VremenskaPrognoza
    {

      public class current
        {
            public long dt { get; set; }
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
            public double visibility { get; set; }
            public double feels_like { get; set; }
            public List<weather> weather { get; set; }
        }
        public class weather {
            public int id { get; set; }
            public string main { get; set; }
            public string description { get; set; }
            public string icon { get; set; }
            
        }
       public class hourly
        {
            public long dt { get; set; }
            public double temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
            public double visibility { get; set; }
            public List<weather> weather { get; set; }
        }
        public class temp
        {
            public double day { get; set; }
            public double min { get; set; }
            public double max { get; set; }
            public double nigh { get; set; }
            public double eve { get; set; }
            public double morn { get; set; }

        }
        public class daily
        {
            public long dt { get; set; }
            public temp temp { get; set; }
            public double pressure { get; set; }
            public double humidity { get; set; }
            public double visibility { get; set; }
            public List<weather> weather { get; set; }
        }

       

      
      
        public class root
        {
            public root( double lat, double lon, current current, List<daily> daily, List<hourly> hourly)
            {
             
                this.lat = lat;
                this.lon = lon;
                this.current = current;
                this.daily = daily;
                this.hourly = hourly;
             
              
            }
          
           public double lat { get; set; }
           public double lon { get; set; }
            public current current { get; set; }
           public List<daily> daily { get; set; }
            public List<hourly> hourly { get; set; }

        }
    }

       
}
