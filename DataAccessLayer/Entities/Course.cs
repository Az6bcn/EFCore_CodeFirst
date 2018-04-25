using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Course
    {
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public virtual IList<Student> Students { get; set; }
        public virtual Teacher Teacher { get; set; }
    }
}
