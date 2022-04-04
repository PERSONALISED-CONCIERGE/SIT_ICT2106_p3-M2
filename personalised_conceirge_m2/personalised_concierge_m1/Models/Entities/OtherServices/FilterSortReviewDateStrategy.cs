﻿using System;
using System.Collections.Generic;
using System.Linq;
using personalised_concierge_m1.Models.Interfaces;

namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public class FilterSortReviewDateStrategy : IStrategy
    {
        //Model Class will create a UnitOfWork to talk to Db.
        private readonly IM2UnitOfWork _m2UnitOfWork;


        public FilterSortReviewDateStrategy(IM2UnitOfWork m2UnitOfWork)
        {
            this._m2UnitOfWork = m2UnitOfWork;
        }

        public IEnumerable<Review> SortASC(int FoodLeisureID)
        {
            var reviews = _m2UnitOfWork.ReviewDetails.GetReviewByFoodLeisure(FoodLeisureID);
            IEnumerable<Review> result = reviews.OrderBy(r => r.Date);
            return result;
        }

        public IEnumerable<Review> SortDSC(int FoodLeisureID)
        {
            var reviews = _m2UnitOfWork.ReviewDetails.GetReviewByFoodLeisure(FoodLeisureID);
            IEnumerable<Review> result = reviews.OrderByDescending(r => r.Date);
            return result;
        }

        public IEnumerable<Review> Filter(int FoodLeisureID, string searchstr)
        {
            var formatedsearchstr = "%" + searchstr + "%";
            var reviews = _m2UnitOfWork.ReviewDetails.GetReviewByDateNFoodLiesure(FoodLeisureID, formatedsearchstr);
            return reviews;
        }
    }
}