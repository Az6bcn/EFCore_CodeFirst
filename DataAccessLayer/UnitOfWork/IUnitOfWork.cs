using DataAccessLayer.Repository.RepositoryAbstraction;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.UnitOfWork
{
    public interface IUnitOfWork: IDisposable
    {
        //Exposes our specific Repositories Interfaces has properties/fields, each one implements the IRepository.
        IStudentsRepository Student { get; }
        ICoursesRepository Course { get; }
        ITeachersRepository Teacher { get; }

        int Complete();
    }
}
