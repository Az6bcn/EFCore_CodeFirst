using DataAccessLayer.Entities;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repository.RepositoryAbstraction
{
    public interface ICoursesRepository: IBaseRepository<Course>
    {
    }
}
