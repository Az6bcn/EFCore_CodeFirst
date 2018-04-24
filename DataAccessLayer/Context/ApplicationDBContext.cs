using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccessLayer.Context
{
    public class ApplicationDBContext: DbContext
    {
        // Expose our Entities as DBSet. 
        // DBSet<T> typically corresponds to a database table, and an entity corresponds to a row in the table.
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentAddress> StudentAddresses { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }


        //  DbModelBuilder class is what we can use to build our model rather than using Data Annotation
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            /************************* Configure Properties ==> separated in different file.
             *  Separated configurations out to individual files per entity 
             * ***************************/
             

            /*  separate configurations out to individual files per entity
             * https://www.learnentityframeworkcore.com/configuration/fluent-api
             * */
             

        }
    }
}
