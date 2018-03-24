using Entities.Entities;
using Entities.IRepositories;
using System.Collections.Generic;
using System.Linq;


namespace Persistence.Repositories
{
    public class CourseRepository:Repository<Course>,ICourseRepository
    {
        public CourseRepository(PortfolioContext context)
        : base(context)
        {
        }

        public PortfolioContext PortfolioContext
        {
            get { return Context as PortfolioContext; }
        }

        public IEnumerable<Course> GetTopSellingCourses(int count)
        {
            return PortfolioContext.Courses.OrderByDescending(c => c.FullPrice).Take(count).ToList();
        }

        public IEnumerable<Course> GetCoursesWithAuthors(int pageIndex, int pageSize = 10)
        {
            return PortfolioContext.Courses
                .OrderBy(c => c.Name)
                .Skip((pageIndex - 1) * pageSize)
                .Take(pageSize)
                .ToList();
        }


    }
}
