using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Models.Interfaces.Itineraries;

namespace personalised_concierge_m1.Data.Itineraries
{
    public class BlogRepo : GenericRepo<Blog>, IBlogRepo
    {
        public BlogRepo(ConciergeContext context) : base(context)
        {
        }
        public IBlogRepo getAllBlogs()
        {
            throw new System.NotImplementedException();
        }
        public IBlogRepo getBlogById(int blog_id)
        {
            throw new System.NotImplementedException();
        }
    }
}
