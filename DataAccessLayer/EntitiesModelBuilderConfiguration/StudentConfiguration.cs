using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.EntitiesModelBuilderConfiguration
{
    /*  separate configurations out to individual files per entity
     * https://www.learnentityframeworkcore.com/configuration/fluent-api
     * */

    public class StudentConfiguration: IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> modelBuilder)
        {
            /************************************ Properties Configuration ******************************************/

            // primary key 
            modelBuilder.HasKey(pk => pk.studentID);

            //An identity column is a column that stores numbers that increment by one with each insertion.
            modelBuilder.Property(pk => pk.studentID)
                .ValueGeneratedOnAdd();

            modelBuilder.Property(fn => fn.FirstName)
                .IsRequired()
                .HasMaxLength(250);

            modelBuilder.Property(ln => ln.LastName)
                .IsRequired()
                .HasMaxLength(250);

            modelBuilder.Property(dob => dob.DateOfBirth)
                .IsRequired()
                .HasMaxLength(250);



            /********************************* Setting Up Relationships With Navigation Property ********************/
            // 1-1 Relationsgip:  Student ----> StudentAddress
            modelBuilder.HasOne(ad => ad.StudentAddress)
                        .WithOne(st => st.Student)
                        .HasForeignKey<StudentAddress>(fk => fk.StudentID)
                        .IsRequired();

            // Many-Many Relationsgip:  Student <----> Course, so we configure two 1-Many Relationships and a new Entity to represent the join table for many to many relationship
            

        }
    }
}
