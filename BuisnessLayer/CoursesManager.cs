using DataAccessLayer.Entities;
using DataAccessLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BuisnessLayer
{
    public class CoursesManager
    {
        private readonly IUnitOfWork unitOfWork;

        public CoursesManager(IUnitOfWork _unitOfWork)
        {
            unitOfWork = _unitOfWork;
        }


        public async Task<IEnumerable<Course>> GetAllCoursesAsync()
        {
            var courses = await unitOfWork.Course.GetAllAsync("spd_GetAllCourses");
                return courses;
        }
    }
}
