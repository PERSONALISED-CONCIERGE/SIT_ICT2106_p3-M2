using System;
using System.Collections.Generic;
using System.Linq;

namespace personalised_concierge_m1.Models.Entities.OtherServices
{
    public class SortReviewIDStrategy: IStrategy
    {
        public SortReviewIDStrategy()
        {

        }

        public IEnumerable<Review> SortASC(object data)
        {
            var reviews = data as IEnumerable<Review>;
            IEnumerable<Review> result = reviews.OrderBy(r => r.review_id);
            return result;
        }

        public IEnumerable<Review> SortDSC(object data)
        {
            var reviews = data as IEnumerable<Review>;
            IEnumerable<Review> result = reviews.OrderByDescending(r => r.review_id);
            return result;
        }
    }
}
