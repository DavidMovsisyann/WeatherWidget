﻿namespace WeatherWidget.Models
{
    public class WeatherModel
    {

        public int all { get; set; }
        public int lon { get; set; }
        public int lat { get; set; }
        public double temp { get; set; }
        public double feels_like { get; set; }
        public double temp_min { get; set; }
        public double temp_max { get; set; }
        public int pressure { get; set; }
        public int humidity { get; set; }
        public int sea_level { get; set; }
        public int grnd_level { get; set; }
        public string _base { get; set; }
        public int visibility { get; set; }
        public int dt { get; set; }
        public int timezone { get; set; }
        public int id { get; set; }
        public string name { get; set; }
        public int cod { get; set; }
        public string country { get; set; }
        public int sunrise { get; set; }
        public int sunset { get; set; }
        public string main { get; set; }
        public string description { get; set; }
        public string icon { get; set; }
        public double speed { get; set; }
        public int deg { get; set; }
        public double gust { get; set; }



    }
}
