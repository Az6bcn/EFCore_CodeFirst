using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Abstraction
{
    public interface IBaseRepository<TEntityType> where TEntityType: class 
    {
         Task<IEnumerable<TEntityType>> GetAllAsync(String StoredProcedureName);
    }
}
