using Microsoft.AspNetCore.Mvc;
using personalised_concierge_m1.Models.Entities.Attraction;
using System;
using System.IO;
using System.Net;
using System.Xml;
using System.Device.Location;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace personalised_concierge_m1.Controllers
{
    public class AttractionController : Controller
    {
        private Attraction attraction = new Attraction();
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
            string changiairport = GetLocation(1.359167, 103.989441);
            string jurongbirdpark = GetLocation(1.318707, 103.706442);
            string zoo = GetLocation(1.4043, 103.7930);
            string mbs = GetLocation(1.2847, 103.8610);
            string gardenbay = GetLocation(1.2816, 103.8636);
            string orchidgarden = GetLocation(1.3127, 103.8137);
            string marinabarage = GetLocation(1.2807, 103.8711);
            string artscience = GetLocation(1.2863, 103.8593);
            ViewBag.Sentosa = ((GetDrivingDistanceInMiles(((watcher.Position.Location).ToString()), Sentosa).ToString()));
            ViewBag.Changi = ((GetDrivingDistanceInMiles(((watcher.Position.Location).ToString()), changiairport).ToString()));
            //ViewBag.JurongBird = ((GetDrivingDistanceInMiles(((watcher.Position.Location).ToString()), jurongbirdpark).ToString()));
            //ViewBag.zoo = (GetDrivingDistanceInMiles(((watcher.Position.Location).ToString()), zoo).ToString());
            //ViewBag.mbs = (GetDrivingDistanceInMiles(((watcher.Position.Location).ToString()), mbs).ToString());
            //ViewBag.gardenbay = (GetDrivingDistanceInMiles(((watcher.Position.Location).ToString()), gardenbay).ToString());
            //ViewBag.orchidgarden = (GetDrivingDistanceInMiles(((watcher.Position.Location).ToString()), orchidgarden).ToString());
            //ViewBag.marinabarrage = (GetDrivingDistanceInMiles(((watcher.Position.Location).ToString()), marinabarage).ToString());
            //ViewBag.artscience = (GetDrivingDistanceInMiles(((watcher.Position.Location).ToString()), artscience).ToString());
            return View(attraction);
        }


    }
}