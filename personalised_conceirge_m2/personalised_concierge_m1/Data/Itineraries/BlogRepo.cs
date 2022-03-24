using System.Collections.Generic;
using System.Linq;
using personalised_concierge_m1.Models.Entities.Itineraries;
using personalised_concierge_m1.Models.Interfaces.Itineraries;

namespace personalised_concierge_m1.Data.Itineraries
{
    public class BlogRepo : GenericRepo<Blog>, IBlogRepo
    {
        public BlogRepo(ConciergeContext context) : base(context)
        {
        }
        public IEnumerable<Blog> GetAllBlogs()
        {
            return _context.Set<Blog>().ToList();
        }
        public Blog GetBlogByID(int blog_id)
        {
            return _context.Set<Blog>().Find(blog_id);
        }
    }
}
