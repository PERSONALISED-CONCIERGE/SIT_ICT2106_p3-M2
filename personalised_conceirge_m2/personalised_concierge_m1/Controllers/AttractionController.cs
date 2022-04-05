using Microsoft.AspNetCore.Mvc;
using personalised_concierge_m1.Models.Entities.Attraction;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personalised_concierge_m1.Controllers
{
    public class AttractionController : Controller
    {
        private Attraction attraction = new Attraction();

        List<Attraction> attractionList = new List<Attraction>(){
                new Attraction{attractionId = 0, attractionName = "Universal Studio Singapore", attractionImage = "https://coveringmiles.com/wp-content/uploads/Universal-Studio-Singapore/uss-singapore.jpg", attractionDescription = "100km", attractionPrice = 50, attractionVote = 57},
                new Attraction{attractionId = 1, attractionName = "Changi Airport", attractionImage = "https://wallpapercave.com/wp/wp4706740.jpg", attractionDescription = "30km", attractionPrice = 100, attractionVote = 40},
                new Attraction{attractionId = 2, attractionName = "Jurong Bird Park", attractionImage = "https://th.bing.com/th/id/R.1f1bf7056975fd71e503a15cfef4b00b?rik=Bq0FHjx3OwWirA&riu=http%3a%2f%2fimg.hulutrip.com%2f2016%2f0912%2f20160912051648928.jpg&ehk=YurTVEiVktxaOXhmxi58XnL5YHEj%2fB8rAVDUB5LN8D8%3d&risl=&pid=ImgRaw&r=0", attractionDescription = "40km", attractionPrice = 20, attractionVote = 30},
                new Attraction{attractionId = 3, attractionName = "Singapore Zoo", attractionImage = "https://th.bing.com/th/id/R.06aa49218323a2e9e828de57411fd1b1?rik=Hr4SOwkUW5DdwA&riu=http%3a%2f%2fwww.wheninmanila.com%2fwp-content%2fuploads%2f2015%2f11%2fIMG_20151019_182918-01-e1447168453303.jpeg&ehk=t0kAYaRCr8sL%2fY2s%2fbrNU5jNfdJJ6zSusAC8ykKS%2fyY%3d&risl=&pid=ImgRaw&r=0", attractionDescription = "20km", attractionPrice = 30, attractionVote = 108},
                new Attraction{attractionId = 4, attractionName = "Marina Bay Sands", attractionImage = "https://backiee.com/static/wpdb/wallpapers/1920x1080/239533.jpg", attractionDescription = "10km", attractionPrice = 40, attractionVote = 89},
                new Attraction{attractionId = 5, attractionName = "Gardens by the Bay", attractionImage = "https://th.bing.com/th/id/R.e5637d0360bc83a02b5caf201185a608?rik=SxtD%2fWQzVRiXzg&riu=http%3a%2f%2fwww.marriedtoplants.com%2fwp-content%2fuploads%2f2016%2f08%2fgardens-by-the-bay-supertree-walk_.jpg&ehk=yruJFhWouk2KyIQfqDy5l83xZ6w9NnfauYigouKDvXc%3d&risl=&pid=ImgRaw&r=0", attractionDescription = "5km", attractionPrice = 60, attractionVote = 72},
                new Attraction{attractionId = 6, attractionName = "Singapore Botanic Gardens", attractionImage = "https://mustsharenews.com/wp-content/uploads/2015/07/THIS.jpg", attractionDescription = "10km", attractionPrice = 80, attractionVote = 90},
                new Attraction{attractionId = 7, attractionName = "National Orchid Garden", attractionImage = "https://www.singaporetravelhub.com/wp-content/uploads/2017/08/National-Orchid-Garden-05.jpg?x47978", attractionDescription = "10km", attractionPrice = 30, attractionVote = 32},
                new Attraction{attractionId = 8, attractionName = "Marina Barrage", attractionImage = "https://i.ytimg.com/vi/ith1yDFzVcc/maxresdefault.jpg", attractionDescription = "3km", attractionPrice = 20, attractionVote = 121},
                new Attraction{attractionId = 9, attractionName = "ArtScience Museum", attractionImage = "https://live.staticflickr.com/6064/6140047055_7d12ff66c2_b.jpg", attractionDescription = "15km", attractionPrice = 20, attractionVote = 31}
            };

        public IActionResult Index()
        {
            return View(attractionList);
        }

        // GET: FoodEvents/Details/5
        public async Task<IActionResult> ViewDetails(int id)
        {
            if (id == null)
            {
                return NotFound();
            }
            //var attraction = attractionList.FindIndex(m => m.attractionID == id);
            if (attraction == null)
            {
                return NotFound();
            }

            return View(attractionList[id]);
        }
    }
}