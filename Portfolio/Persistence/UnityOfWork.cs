using Entities;
using Entities.IRepositories;
using Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence
{
    public class UnityOfWork:IUnityOfWork
    {
        private readonly PortfolioContext _context;

        public UnityOfWork(PortfolioContext context)
        {
            _context = context;
            Courses = new CourseRepository(_context);

        }

        public ICourseRepository Courses { get; private set; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
