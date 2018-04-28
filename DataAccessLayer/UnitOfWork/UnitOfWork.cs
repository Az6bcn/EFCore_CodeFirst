using DataAccessLayer.Context;
using DataAccessLayer.Repository;
using DataAccessLayer.Repository.RepositoryAbstraction;

namespace DataAccessLayer.UnitOfWork
{
    public class UnitOfWork: IUnitOfWork
    {
        // ApplicationDbContext
        private readonly ApplicationDBContext myAppDbContext;

        // DI DbContext into Unit Of Work
        public UnitOfWork(ApplicationDBContext _myAppDbContext)
        {
            myAppDbContext = _myAppDbContext;

            /* Initialise all our repositories 
             * Declare Instance of Repositories implementing the Repositories interface */
            Student = new StudentRepository(myAppDbContext);
            Teacher = new TeachersRepository(myAppDbContext);
            Course = new  CoursesRepository(myAppDbContext);

        }

        // exposes our Interfaces (contract) => we connect to them to use our repositories and perform CRUD
        public IStudentsRepository Student { get; private set; }
        public ITeachersRepository Teacher { get; private set; }
        public ICoursesRepository Course { get; private set; }

        //Calls the SaveChanges on the Context
        public int Complete()
        {
            return myAppDbContext.SaveChanges();
        }


        //Implementation of the Dispose Method to Dispose the Context
        public void Dispose()
        {
            myAppDbContext.Dispose();
        }
    }
}
