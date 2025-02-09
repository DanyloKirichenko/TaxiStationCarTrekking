using GMap.NET;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace TaxiStationCarTrekking
{
    public class Route
    {
        public string Name { get; }
        public List<PointLatLng> RouteTransport { get; }
        public Route(string Name, List<PointLatLng> RouteTransport)
        {
            this.Name = Name;

            this.RouteTransport = new List<PointLatLng>();
            foreach (var p in RouteTransport)
            {
                this.RouteTransport.Add(new PointLatLng(p.Lat, p.Lng));
            }
        }
        public override string ToString()
        {
            return Name;
        }
        public override bool Equals(object obj)
        {
            if ((obj == null) || !this.GetType().Equals(obj.GetType()))
            {
                return false;
            }
            Route r = obj as Route;

            if (!Name.Equals(r.Name)) return false;

            foreach(var point in RouteTransport)
            {
                if (r.RouteTransport.FindIndex(x => x == point) == -1)
                    return false;
            }
            return true;
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public static List<Route> Import(string fileName)
        {
            List<Route> route = new List<Route>();
            if (File.Exists(fileName))
            {
                try
                {
                    string jsonString = File.ReadAllText(fileName);
                    route = JsonConvert.DeserializeObject<List<Route>>(jsonString);
                }
                catch
                {
                    throw new Exception("Проблема у даних файлу");
                }
            }
            return route;
        }
        public static void Export(List<Route> route, string fileName)
        {
            string content = JsonConvert.SerializeObject(route, Formatting.Indented);
            File.WriteAllText(fileName, content);
        }
    }
}
