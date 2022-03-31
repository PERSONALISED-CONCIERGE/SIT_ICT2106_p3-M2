using System;
using System.Collections.Generic;
using System.Linq;
using personalised_concierge_m1.Models.Interfaces;

namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public class SearchSortRatingsStrategy : IStrategy
    {

        //Model Class will create a UnitOfWork to talk to Db.
        private readonly IM2UnitOfWork _m2UnitOfWork;

        public SearchSortRatingsStrategy(IM2UnitOfWork m2UnitOfWork)
        {
            this._m2UnitOfWork = m2UnitOfWork;
        }

        public IEnumerable<Review> SortASC(int FoodLeisureID)
        {
            var reviews = _m2UnitOfWork.ReviewDetails.GetReviewByFoodLeisure(FoodLeisureID);
            IEnumerable<Review> result = reviews.OrderBy(r => r.rating);
            return result;
        }
        public IEnumerable<Review> SortDSC(int FoodLeisureID)
        {
            var reviews = _m2UnitOfWork.ReviewDetails.GetReviewByFoodLeisure(FoodLeisureID);
            IEnumerable<Review> result = reviews.OrderByDescending(r => r.rating);
            return result;
        }

        public IEnumerable<Review> Search(int FoodLeisureID, string searchstr)
        {
           
            var rate = searchstr switch
            {
                "1" or "one" => Rating.One,
                "2" or "two" => Rating.Two,
                "3" or "three" => Rating.Three,
                "4" or "four" => Rating.Four,
                "5" or "five" => Rating.Five,
                _ => Rating.One,
            };
            var reviews = _m2UnitOfWork.ReviewDetails.GetReviewByRateNFoodLiesure(FoodLeisureID, rate);
            return reviews;
        }
    }
}
