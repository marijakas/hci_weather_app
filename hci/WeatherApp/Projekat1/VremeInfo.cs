using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekat1
{
    


    public class VremeInfoDaily
    {
        public VremeInfoDaily(string naziv, string temp, string tempMin, string tempMax,  string pressure, string humidity, string dt)
        {
            this.naziv = naziv;
            this.temp = temp;
            this.dt = dt;
            this.tempMin = tempMin;
            this.tempMax = tempMax;
            this.pressure = pressure;
            this.humidity = humidity;
            // this.temp_min = temp_min;
            //this.temp_max = temp_max;

        }
        public string naziv { get; set; }
        public string dt { set; get; }
        public string tempMin { get; set; }
        public string tempMax { get; set; }
        public string temp { get; set; }
        public string pressure { get; set; }
        public string humidity { get; set; }
        // public double temp_min { get; set; }
        //public double temp_max { get; set; }

    }

    public class VremeInfoHourly
    {
        public VremeInfoHourly(string naziv, string temp, string pressure, string humidity, string dt)
        {
            this.naziv = naziv;
            this.temp = temp;
            this.dt = dt;
            this.pressure = pressure;
            this.humidity = humidity;
            // this.temp_min = temp_min;
            //this.temp_max = temp_max;

        }

        public string naziv { get; set; }
        public string dt { get; set; }
        public string temp { get; set; }
        public string pressure { get; set; }
        public string humidity { get; set; }
        // public double temp_min { get; set; }
        //public double temp_max { get; set; }

    }


    public class VremeInfoCurrent
    {
        public VremeInfoCurrent(string naziv, string temp,  string pressure, string humidity, string dt, string visibility)
        {
            this.visibility = visibility;
            this.naziv = naziv;
            this.dt = dt;
            this.temp = temp;
            this.pressure = pressure;
            this.humidity = humidity;
            
        // this.temp_min = temp_min;
        //this.temp_max = temp_max;

        }
    public string naziv { get; set; }
    public string dt { get; set; }
    public string temp { get; set; }
    public string pressure { get; set; }
    public string humidity { get; set; }
    public string visibility { get; set; }
    // public double temp_min { get; set; }
    //public double temp_max { get; set; }

}

}
