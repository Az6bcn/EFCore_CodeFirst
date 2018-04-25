using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntitiesModelBuilderConfiguration
{
    public class CoursesConfiguration
    {
        public void Configure(EntityTypeBuilder<Course> modelBuilder)
        {
            /************************************ Properties Configuration ******************************************/

            // primary key 
            modelBuilder.HasKey(pk => pk.CourseID);

            //An identity column is a column that stores numbers that increment by one with each insertion.
            modelBuilder.Property(pk => pk.CourseID)
                    .ValueGeneratedOnAdd();

            modelBuilder.Property(cn => cn.CourseName)
                    .IsRequired()
                    .HasMaxLength(250);


            /********************************* Setting Up Relationships With Navigation Property ********************/
            /* Many-Many Relationsgip:  Student <----> Course, so we configure two 1-Many Relationships and a new Entity 
            to represent the join table for many to many relationship *
            I configured it in the StudentCourse Entity*/
        }
    }
}
