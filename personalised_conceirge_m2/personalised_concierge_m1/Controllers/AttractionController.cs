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

        List<Attraction> attractionList = new List<Attraction>(){
                new Attraction{attractionId = 0, attractionName = "Universal Studio Singapore", attractionImage = "https://coveringmiles.com/wp-content/uploads/Universal-Studio-Singapore/uss-singapore.jpg", attractionDescription = "Universal Studios Singapore is a theme park located within the Resorts World Sentosa at Sentosa, Singapore. It features 28 rides, shows, and attractions in seven themed zones. It is one of the six Universal Studios theme parks around the world.", attractionPrice = 50, attractionVote = 57},
                new Attraction{attractionId = 1, attractionName = "Changi Airport", attractionImage = "https://wallpapercave.com/wp/wp4706740.jpg", attractionDescription = "Singapore Changi Airport, commonly known as Changi Airport, is a major civilian international airport that serves Singapore, and is one of the largest transportation hubs in Asia.", attractionPrice = 100, attractionVote = 40},
                new Attraction{attractionId = 2, attractionName = "Jurong Bird Park", attractionImage = "https://th.bing.com/th/id/R.1f1bf7056975fd71e503a15cfef4b00b?rik=Bq0FHjx3OwWirA&riu=http%3a%2f%2fimg.hulutrip.com%2f2016%2f0912%2f20160912051648928.jpg&ehk=YurTVEiVktxaOXhmxi58XnL5YHEj%2fB8rAVDUB5LN8D8%3d&risl=&pid=ImgRaw&r=0", attractionDescription = "Jurong Bird Park is an aviary and tourist attraction in Jurong, Singapore. The bird park covers an area of 0.2 square kilometres on the western slope of Jurong Hill, the highest point in the Jurong region.", attractionPrice = 20, attractionVote = 30},
                new Attraction{attractionId = 3, attractionName = "Singapore Zoo", attractionImage = "https://th.bing.com/th/id/R.06aa49218323a2e9e828de57411fd1b1?rik=Hr4SOwkUW5DdwA&riu=http%3a%2f%2fwww.wheninmanila.com%2fwp-content%2fuploads%2f2015%2f11%2fIMG_20151019_182918-01-e1447168453303.jpeg&ehk=t0kAYaRCr8sL%2fY2s%2fbrNU5jNfdJJ6zSusAC8ykKS%2fyY%3d&risl=&pid=ImgRaw&r=0", attractionDescription = "The Singapore Zoo, formerly known as the Singapore Zoological Gardens or Mandai Zoo, occupies 28 hectares on the margins of Upper Seletar Reservoir within Singapore's heavily forested central catchment area.", attractionPrice = 30, attractionVote = 108},
                new Attraction{attractionId = 4, attractionName = "Marina Bay Sands", attractionImage = "https://backiee.com/static/wpdb/wallpapers/1920x1080/239533.jpg", attractionDescription = "Marina Bay Sands is a destination for those who appreciate luxury. An integrated resort notable for transforming Singapore’s city skyline, it comprises three 55-storey towers of extravagant hotel rooms and luxury suites with personal butler services.", attractionPrice = 40, attractionVote = 89},
                new Attraction{attractionId = 5, attractionName = "Gardens by the Bay", attractionImage = "https://th.bing.com/th/id/R.e5637d0360bc83a02b5caf201185a608?rik=SxtD%2fWQzVRiXzg&riu=http%3a%2f%2fwww.marriedtoplants.com%2fwp-content%2fuploads%2f2016%2f08%2fgardens-by-the-bay-supertree-walk_.jpg&ehk=yruJFhWouk2KyIQfqDy5l83xZ6w9NnfauYigouKDvXc%3d&risl=&pid=ImgRaw&r=0", attractionDescription = "The Gardens by the Bay is a nature park spanning 101 hectares in the Central Region of Singapore, adjacent to the Marina Reservoir. The park consists of three waterfront gardens: Bay South Garden, Bay East Garden and Bay Central Garden.", attractionPrice = 60, attractionVote = 72},
                new Attraction{attractionId = 6, attractionName = "Singapore Botanic Gardens", attractionImage = "https://mustsharenews.com/wp-content/uploads/2015/07/THIS.jpg", attractionDescription = "The Singapore Botanic Gardens is a 163-year-old tropical garden located at the fringe of the Orchard Road shopping district in Singapore. It is one of three gardens, and the only tropical garden, to be honoured as a UNESCO World Heritage Site. The Botanic Gardens has been ranked Asia's top park attraction since 2013, by TripAdvisor Travellers' Choice Awards. It was declared the inaugural Garden of the Year, International Garden Tourism Awards in 2012, and received Michelin's three-star rating in 2008.", attractionPrice = 80, attractionVote = 90},
                new Attraction{attractionId = 7, attractionName = "National Orchid Garden", attractionImage = "https://www.singaporetravelhub.com/wp-content/uploads/2017/08/National-Orchid-Garden-05.jpg?x47978", attractionDescription = "The Singapore Botanic Gardens has been developed along a 3-Core Concept. The three Cores consist of Tanglin, which is the heritage core that retains the old favourites and rustic charms of the historic Gardens; Central, which is the tourist belt of the Gardens; and Bukit Timah, which is the educational and recreational zone. Each Core offers an array of attractions.", attractionPrice = 30, attractionVote = 32},
                new Attraction{attractionId = 8, attractionName = "Marina Barrage", attractionImage = "https://i.ytimg.com/vi/ith1yDFzVcc/maxresdefault.jpg", attractionDescription = "Built across the mouth of Marina Channel, Marina Barrage (MB) creates Singapore’s 15th reservoir, and the first in the heart of the city. With a catchment area of 10,000 hectares, Marina catchment is the island’s largest and most urbanised catchment. Together with two other reservoirs, Marina Reservoir has increased Singapore’s water catchment from half to two-thirds of the country’s land area.", attractionPrice = 20, attractionVote = 121},
                new Attraction{attractionId = 9, attractionName = "ArtScience Museum", attractionImage = "https://live.staticflickr.com/6064/6140047055_7d12ff66c2_b.jpg", attractionDescription = "As the name suggests, ArtScience Museum at Marina Bay Sands beautifully fuses art and science to tell fascinating stories. This premier venue houses a constantly changing line-up of major international touring exhibitions, brought in through collaborations with organisations such as the American Museum of Natural History, the Smithsonian Institute and world-renowned furniture designer Herman Miller.", attractionPrice = 20, attractionVote = 31}
            };

        public IActionResult Index()
        {
            return View(attractionList);
        }

        public async Task<IActionResult> ViewDetails(int id)
        {
            if (id == null)
            {
                return NotFound();
            }

            if (attraction == null)
            {
                return NotFound();
            }

            return View(attractionList[id]);
        }

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
        public IActionResult Suggestion()
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