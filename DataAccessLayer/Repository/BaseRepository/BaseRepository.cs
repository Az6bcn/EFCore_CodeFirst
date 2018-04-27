using DataAccessLayer.Context;
using Microsoft.EntityFrameworkCore;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository.BaseRepository
{
    public class BaseRepository<TEntityType> : IBaseRepository<TEntityType> where TEntityType: class
    {
        
        private readonly ApplicationDBContext dbContext;

        // Will recieve original application dbContext
        public BaseRepository(ApplicationDBContext _dbContext)
        {
            dbContext = _dbContext;
        }

        public async Task<IEnumerable<TEntityType>> GetAllAsync(String  StoredProcedureName) {

            var response = await dbContext.Set<TEntityType>().FromSql("EXEC"+" "+$"{StoredProcedureName}").ToListAsync();

            return response;
        }
    }
}
