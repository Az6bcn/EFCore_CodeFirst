    using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Student
    {
        public int studentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        // FK
        public int StudentAddressID { get; set; }
        public virtual StudentAddress StudentAddress { get; set; }

        // public virtual IList<Course> Courses { get; set; }
        /* EF Core doesn't support Many - Many
         add navigation properties to either side of the many-to-many relations that point to the intermediate join entity */
        public virtual IList<StundentCourse> StundentCourse { get; set; }
    }
}
