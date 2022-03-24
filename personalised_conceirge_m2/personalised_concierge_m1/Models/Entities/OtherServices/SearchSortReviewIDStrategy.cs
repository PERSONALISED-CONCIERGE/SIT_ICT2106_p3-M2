using System;
using System.Collections.Generic;
using System.Linq;
using personalised_concierge_m1.Models.Interfaces;
using personalised_concierge_m1.Models.Entities.FoodLeisureServices;

namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public class SearchSortReviewIDStrategy : IStrategy
    {

        //Model Class will create a UnitOfWork to talk to Db.
        private readonly IM2UnitOfWork _m2UnitOfWork;

        public SearchSortReviewIDStrategy(IM2UnitOfWork m2UnitOfWork)
        {
            this._m2UnitOfWork = m2UnitOfWork;
        }

        public IEnumerable<Review> SortASC(int FoodLeisureID)
        {
            var reviews = _m2UnitOfWork.ReviewDetails.GetReviewByFoodLeisure(FoodLeisureID).OrderBy(r => r.review_id);
            return reviews;
        }

        public IEnumerable<Review> SortDSC(int FoodLeisureID)
        {
            var reviews = _m2UnitOfWork.ReviewDetails.GetReviewByFoodLeisure(FoodLeisureID).OrderByDescending(r => r.review_id);
            return reviews;
        }

        public IEnumerable<Review> Search(int FoodLeisureID, string searchstr)
        {
            var id = Int32.Parse(searchstr);
            var reviews = _m2UnitOfWork.ReviewDetails.GetReviewByIDNFoodLiesure(FoodLeisureID,id);
            return reviews;
        }
    }
}
