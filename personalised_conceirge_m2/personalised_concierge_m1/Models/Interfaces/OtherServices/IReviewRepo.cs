﻿using System.Collections.Generic;
using personalised_concierge_m1.Models.Entities.OtherServices;

namespace personalised_concierge_m1.Models.Interfaces.OtherServices
{
    public interface IReviewRepo:IGenericRepo<Review>
    {
        //TODO: Methods to be defined in the repo interface classes and implemented in the repository.
        //RoomType Entity
        Review GetReviewByID(int review_id);
        IEnumerable<Review> GetAllReviews();
        IEnumerable<Review> GetReviewByFoodLeisure(int foodleisure_id);
        IEnumerable<Review> GetBusinessReviewByFoodLeisure(int foodleisure_id);

        IEnumerable<Review> GetReviewByDateNFoodLiesure(int foodleisure_id, string date);
        IEnumerable<Review> GetReviewByIDNFoodLiesure(int foodleisure_id, int id);
        IEnumerable<Review> GetReviewByRateNFoodLiesure(int foodleisure_id, Rating rating);
        IEnumerable<Review> GetReviewByDescriptionNFoodLiesure(int foodleisure_id, string description);
    }
}