﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Entities
{
    public class StundentCourse
    {
        public int CourseID { get; set; }
        public Course Course { get; set; }
        public int studentID { get; set; }
        public Student Student { get; set; }
    }
}
