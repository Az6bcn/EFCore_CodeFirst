using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class Student
    {
        public Student()
        {
            Courses = new List<Course>();
        }

        public int studentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public virtual StudentAddress StudentAddress { get; set; }
        public virtual IList<Course> Courses { get; set; }
    }
}
