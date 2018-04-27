using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BuisnessLayer;
using DataAccessLayer.Entities;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs;

namespace EF_DTO_CODEFIRST.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // Create a field to store the mapper object
        private readonly IMapper mapper;
        private readonly CoursesManager courseManager;

        public ValuesController(CoursesManager _courseManager, IMapper _mapper)
        {
            courseManager = _courseManager;
            mapper = _mapper;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var courses = await courseManager.GetAllCoursesAsync();

            // Return DTO
            var courseDTO = mapper.Map<IEnumerable<Course>, IEnumerable<CourseDTO>>(courses);

            return Ok(courseDTO);
        }

      
    }
}
