using AutoMapper;
using DataAccessLayer.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using Model.DTOs;

namespace Model.AutoMapper
{
    public class MappingProfile: Profile
    {
        public MappingProfile()
        {
            // Add as many of these lines as you need to map your objects
            CreateMap<IEnumerable<Course>, IEnumerable<CourseDTO>>();
            CreateMap<Student, StudentDTO>();
        }
    }
}
