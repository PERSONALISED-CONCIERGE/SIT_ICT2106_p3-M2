
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
            
            var maxItem = 50;
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
            // sorts the dict according to how many times it has appeared, output is IEnumerable<KeyValuePair<TKey, TValue>>
            var sortedDict = dict.OrderByDescending(pair => pair.Value).Take(maxItem);

            
            // inserts the items into attractionlist
            // item is the FoodLeisure object
            var insertTracker = 0;
            foreach (var item in sortedDict)
            {
                foreach (var itineraryItem in allAttractionInItinerary){
                

                    // checks if the name of the item is the same as the sorted key
                    if(item.key == itineraryItem.name){

                        // if the final list does not contain item, add into the list and break inner loop
                        if(!attractionlist.contains(itineraryItem)){
                            attractionlist.add(itineraryItem);
                            break;
                        {
                    }
                    
                }
                insertTracker++;

                // limits the amount of items in itinerary going into the list
                if(insertTracker == maxItem){
                    break;
                }
                
            };
            */


            // if no data can be extracted from itinerary, gets the placeholder values for the carousel
            if (attractionlist.Count == 0)
            {
                var counter = 0;
                // getting placeholder data for the recommended attractions
                //_m2UnitOfWork.FoodLeisureDetails.GetAllFoodLeisure();
                var allFoodLeisure = _m2UnitOfWork.FoodLeisureDetails.GetAllFoodLeisure();
                while (attractionlist.Count < maxItem)
                {

                    // checks of the type is POI, due to lack of data, instead check if its a restraunt type (int 2 is POI )
                    foreach(var foodLeisureItem in allFoodLeisure)
                    {

                        if ((int)foodLeisureItem.type == 0)
                        {

                            attractionlist.Add(foodLeisureItem);
                        }


                    }
                    // to prevent infinite loop from not filling up to 6 in the placeholder attraction list, loop up to 50
                    if (counter == maxItem)
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