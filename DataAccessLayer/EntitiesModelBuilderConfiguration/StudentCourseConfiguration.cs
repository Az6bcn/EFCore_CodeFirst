using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Collections.Generic;

namespace DataAccessLayer.EntitiesModelBuilderConfiguration
{
    public class StudentCourseConfiguration
    {
        public void Configure(EntityTypeBuilder<StundentCourse> modelBuilder)
        {

            /********************************* Setting Up Many - Many Relationships by is created by including 
             * an entity class for the join table and mapping two separate one-to-many relationships.********************/

            // JOIN TABLE
            modelBuilder.HasKey(pks => new { pks.studentID, pks.CourseID });

            // 2x 1-Many
            modelBuilder.HasOne(s => s.Student)
                       .WithMany(c => c.StundentCourse)
                       .HasForeignKey(fk => fk.studentID);

            modelBuilder.HasOne(c => c.Course)
                       .WithMany(s => s.StundentCourse)
                       .HasForeignKey(fk => fk.CourseID);


        }
    }
}
