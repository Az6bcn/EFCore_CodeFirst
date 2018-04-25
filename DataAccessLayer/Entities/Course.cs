using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Course
    {

        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public virtual Teacher Teacher { get; set; }

        // public virtual IList<Student> Students { get; set; } 
        /* EF Core doesn't support Many - Many
         add navigation properties to either side of the many-to-many relations that point to the join entity */
        public virtual IList<StundentCourse> StundentCourse { get; set; }
    }
}
