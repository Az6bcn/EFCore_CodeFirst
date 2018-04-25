using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntitiesModelBuilderConfiguration
{
    public class TeacherConfiguration
    {

        public void Configure(EntityTypeBuilder<Teacher> modelBuilder)
        {
            /************************************ Properties Configuration ******************************************/

            // primary key 
            modelBuilder.HasKey(pk => pk.TeacherID);

            //An identity column is a column that stores numbers that increment by one with each insertion.
            modelBuilder.Property(pk => pk.TeacherID)
                    .ValueGeneratedOnAdd();

            modelBuilder.Property(fn => fn.FirstName)
                    .IsRequired()
                    .HasMaxLength(250);

            modelBuilder.Property(ln => ln.LastName)
                    .IsRequired()
                    .HasMaxLength(250);



            /********************************* Setting Up Relationships With Navigation Property ********************/

            // 1- Many : The Many side Entity's PK will be the FK in the one side.

            modelBuilder.HasMany(c => c.Courses)
                        .WithOne(t => t.Teacher)
                        .HasForeignKey(fk => fk.CourseID);
                        
        }

    }
}
