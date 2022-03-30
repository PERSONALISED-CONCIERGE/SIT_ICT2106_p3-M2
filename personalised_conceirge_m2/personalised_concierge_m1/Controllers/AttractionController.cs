using Microsoft.AspNetCore.Mvc;
using personalised_concierge_m1.Models.Entities.Attraction;
using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Device.Location;


namespace personalised_concierge_m1.Controllers
{

    public class AttractionController : Controller

    {
       
        private Attraction attraction = new Attraction();
        //private string latitude;
        //private string longitute;
        //private GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();
        GeoCoordinateWatcher geo = null;
        public double GetDrivingDistanceInMiles(string origin, string destination)
        {

            string url = "https://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + origin + "&destinations=" + destination + "&mode=driving&sensor=false&language=en-EN&units=imperial&key=AIzaSyDTTYqC1kZafWB0Ewsobhe05TyHGzl40qA";

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(responsereader);
            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {
                XmlNodeList distance = xmldoc.GetElementsByTagName("distance");
                return Convert.ToDouble(distance[0].ChildNodes[1].InnerText.Replace(" mi", ""));
            }

            return 0;
        }
        public string GetLocation(double latitude, double longitude)
        {
            string url = "https://maps.googleapis.com/maps/api/geocode/xml?latlng=" + latitude + "," + longitude + "&sensor=false&key=AIzaSyDTTYqC1kZafWB0Ewsobhe05TyHGzl40qA"; 
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader sreader = new StreamReader(dataStream);
            string responsereader = sreader.ReadToEnd();
            response.Close();
            XmlDocument xmldoc = new XmlDocument();
            xmldoc.LoadXml(responsereader);
            if (xmldoc.GetElementsByTagName("status")[0].ChildNodes[0].InnerText == "OK")
            {
                XmlNodeList location = xmldoc.GetElementsByTagName("distance");
                return xmldoc.GetElementsByTagName("formatted_address")[0].ChildNodes[0].InnerText;
            }

            return "";
        }

        public IActionResult Index()
        {
            GeoCoordinateWatcher watcher = new GeoCoordinateWatcher();

            // Do not suppress prompt, and wait 1000 milliseconds to start.
            watcher.TryStart(false, TimeSpan.FromMilliseconds(1000));

            GeoCoordinate coord = watcher.Position.Location;
            string Sentosa = GetLocation(1.2494, 103.8303);
            ViewBag.Title = (GetDrivingDistanceInMiles((watcher.Position.Location).ToString(), Sentosa).ToString());
            return View(attraction);
        }
    }
}
