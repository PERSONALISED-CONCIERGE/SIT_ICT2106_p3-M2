
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using personalised_concierge_m1.Models;
using personalised_concierge_m1.Models.Interfaces;

namespace personalised_concierge_m1.Controllers
{
    public class HomeController : Controller
    {
        //Model Class will create a UnitOfWork to talk to Db.
        private readonly IUnitOfWork _unitOfWork;
        private readonly IM2UnitOfWork _m2UnitOfWork;
        private readonly IM3UnitOfWork _m3UnitOfWork;


        public HomeController(IUnitOfWork unitOfWork, IM2UnitOfWork m2UnitOfWork, IM3UnitOfWork m3UnitOfWork)
        {
            this._unitOfWork = unitOfWork;
            this._m2UnitOfWork = m2UnitOfWork;
            this._m3UnitOfWork = m3UnitOfWork;
        }
        public IActionResult Index()
        {
            
            //variable getting data from DB and storing in an Object Example
            var myRoom = _unitOfWork.RoomDetails.GetById(1);
            var myReservation = _unitOfWork.ReservationDetails.GetById(1);
            var myAccount = _unitOfWork.AccountDetails.GetById(1);
            var myLeisure = _m2UnitOfWork.FoodLeisureDetails.GetById(1);
            //var myEnum = _m2UnitOfWork.ReviewDetails.GetById(1);
            var myRequest = _m3UnitOfWork.RequestDetails.GetById(1);

            var maxItem = 50;
            ViewData["myRoom"] = myRoom;
            ViewData["myAccount"] = myAccount;
            ViewData["myLeisure"] = myLeisure;
            //ViewData["myenum"] = myEnum;
            ViewData["myrequest"] = myRequest;


            List<Models.Entities.FoodLeisureServices.FoodLeisure> attractionlist = new List<Models.Entities.FoodLeisureServices.FoodLeisure>();
            // code for getting all itinerary




            // pseudo code for the extraction of attractions from itinerary
            //List<Models.Entities.Itineraries.Itinerary> allAttractionInItinerary = _m2UnitOfWork.ItineraryItemDetails.getAllItineraryItems();
            //var recommendedListDict = new Dictionary<string, int>();

            /*
            var itemsInItinerary = 0;
            for (item in allAttractionInItinerary)
            {
                // limits the amount of items in itinerary going into the list
                if(itemsInItinerary > maxItem){
                    break;
                }
                if((int)item.type == 2)
                {
                    if (recommendedList.ContainsKey(item.name))
                    {
                        recommendedList.Add(item.name, 1);
                    }
                    else
                    {
                        var record = recommendedList[item.name];
                        tempKeyPair = (item.name, record.Value + 1);
                    }
                    
                }
                itemsInItinerary++;
            };
            // sorts the dict according to how many times it has appeared
            var sortedDict = dict.OrderByDescending(pair => pair.Value).Take(maxItem).ToDictionary(pair => pair.Key, pair => pair.Value);

            
            // inserts the items into attractionlist
            // item is the FoodLeisure object

            for (item in allAttractionInItinerary)
            {
                // limits the amount of items in itinerary going into the list
                if(itemsInItinerary > 50){
                    break;
                }
                if(recommendedList.containsKey(item.name))
                {
                    attractionlist.add(item);
                    
                }
                itemsInItinerary++;
            };
            */


            // if no data can be extracted from itinerary, gets the placeholder values for the carousel
            if (attractionlist.Count == 0)
            {
                var counter = 0;
                // getting placeholder data for the recommended attractions
                while (attractionlist.Count < 6)
                {
                    if (_m2UnitOfWork.FoodLeisureDetails.GetById(counter) != null)
                    {

                        // checks of the type is POI, due to lack of data, instead check if its restraunt
                        if ((int)_m2UnitOfWork.FoodLeisureDetails.GetById(counter).type == 0)
                        //if((int)_m2UnitOfWork.FoodLeisureDetails.GetById(counter).type == 2)
                        {
                            attractionlist.Add(_m2UnitOfWork.FoodLeisureDetails.GetById(counter));
                        }
                    }

                    // to prevent infinite loop from not filling up to 6 in the placeholder attraction list, loop up to 50
                    if (counter == 50)
                    {
                        break;
                    }
                    counter++;
                }
            }
            
            ViewData["attractionList"] = attractionlist;
            //data is return to the view to be used there.
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel {RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier});
        }

    }
}