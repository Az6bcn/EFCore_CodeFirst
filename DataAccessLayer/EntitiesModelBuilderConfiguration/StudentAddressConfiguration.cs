using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DataAccessLayer.Entities;

namespace DataAccessLayer.EntitiesModelBuilderConfiguration
{
    public class StudentAddressConfiguration : IEntityTypeConfiguration<StudentAddress>
    {
        public void Configure(EntityTypeBuilder<StudentAddress> modelBuilder)
        {
            /************************************ Properties Configuration ******************************************/

            // primary key 
            modelBuilder.HasKey(pk => pk.StudentAddressID);

            //An identity column is a column that stores numbers that increment by one with each insertion.
            modelBuilder.Property(pk => pk.StudentAddressID)
                .ValueGeneratedOnAdd();

            modelBuilder.Property(sa => sa.StreetAddress)
                .IsRequired()
                .HasMaxLength(250);

            modelBuilder.Property(s => s.State)
                .IsRequired()
                .HasMaxLength(250);

            modelBuilder.Property(c => c.City)
                .IsRequired()
                .HasMaxLength(250);

            modelBuilder.Property(pc => pc.PostalCode)
                .IsRequired()
                .HasMaxLength(250); ;


            /********************************* Setting Up Relationships With Navigation Property ********************/
        }
    }

}
