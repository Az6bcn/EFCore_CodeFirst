using DataAccessLayer.Context;
using DataAccessLayer.Entities;
using DataAccessLayer.Repository.BaseRepository;
using DataAccessLayer.Repository.RepositoryAbstraction;
using Microsoft.EntityFrameworkCore;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repository
{
    public class CoursesRepository: BaseRepository<Course>, ICoursesRepository

    {

        public CoursesRepository(ApplicationDBContext dbContext): base(dbContext)
        {

        }

       public void Get()
        {

        }
      

    }
}
