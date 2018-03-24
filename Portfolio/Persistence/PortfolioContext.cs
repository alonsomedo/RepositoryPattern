using Entities.Entities;
using Persistence.EntityConfigurations;
using System.Data.Entity;


namespace Persistence
{
    public class PortfolioContext:DbContext
    {
        public PortfolioContext()
            :base("name=PortfolioConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }

        public virtual DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new CourseConfiguration());
        }

    }
}
