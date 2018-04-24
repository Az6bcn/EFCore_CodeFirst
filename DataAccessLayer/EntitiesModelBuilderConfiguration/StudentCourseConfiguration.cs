using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntitiesModelBuilderConfiguration
{
    public class StudentCourseConfiguration
    {
        public void Configure(EntityTypeBuilder<StundentCourse> modelBuilder)
        {

            /********************************* Setting Up Many - Many Relationships by is created by including 
             * an entity class for the join table and mapping two separate one-to-many relationships.********************/

            modelBuilder.HasKey(pks => new { pks.studentID, pks.CourseID }); // JOIN TABLE

            // 2x 1-Many
            
                        
        }
    }
}
