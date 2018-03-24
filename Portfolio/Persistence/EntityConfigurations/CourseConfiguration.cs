using Entities.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistence.EntityConfigurations
{
    public class CourseConfiguration : EntityTypeConfiguration<Course>
    {
        public CourseConfiguration()
        {
            ToTable("Curso");

            HasKey(c => c.Id);

            Property(c => c.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(c => c.Description)
                .IsRequired()
                .HasMaxLength(2000);

            Property(c => c.Name)
                .IsRequired()
                .HasMaxLength(255);
        }
    }
}
