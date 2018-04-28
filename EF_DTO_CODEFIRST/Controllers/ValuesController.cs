using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using BuisnessLayer;
using DataAccessLayer.Entities;
using DataAccessLayer.IdentityCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Model.DTOs;

namespace EF_DTO_CODEFIRST.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        // Create a field to store the mapper object
        private readonly IMapper _mapper;
        private readonly CoursesManager _courseManager;
        // Identity Managers
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signInManager;

        public ValuesController(CoursesManager courseManager, IMapper mapper,
                                UserManager<ApplicationUser> userManager,
                                SignInManager<ApplicationUser> signInManager )
        {
            _courseManager = courseManager;
            _mapper = mapper;
            _userManager = userManager;
            _signInManager = signInManager;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var courses = await _courseManager.GetAllCoursesAsync();

            // Return DTO
            var courseDTO = _mapper.Map<IEnumerable<Course>, IEnumerable<CourseDTO>>(courses);

            return Ok(courseDTO);
        }

        // GET api/values
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] ApplicationUser user)
        {

            var userToSave = new ApplicationUser()
            {
                FirstName = user.FirstName,
                LastName = user.LastName,
                UserName = user.FirstName
            };
            var identityUser = await _userManager.CreateAsync(userToSave, "Hasexzo1*");
           
            return Ok(identityUser);
        }

    }
}
