using DataAccessLayer.Repository.RepositoryAbstraction;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repository
{
    public class StudentRepository: IStudentsRepository
    {
        public StudentRepository(DbContext dbContext)
        {

        }
    }
}
