using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PowerTeam.DAL.Interface;

namespace PowerTeam.DAL.Reponsitory
{
    public class BaseRepository<T> : IBaseRepository<T>
        where T:class
    {
        internal PTDBContext _ptDbContext;
        internal DbSet<T> entiteSet;

        public BaseRepository(PTDBContext ptDBContext)
        {
            if (ptDBContext == null) throw new ArgumentNullException("dbcontext");
            _ptDbContext = ptDBContext;
            this.entiteSet = ptDBContext.Set<T>();
        }
        public Task Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Exists(Guid primaryKey)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task Insert(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual async Task<T> Single(Guid primaryKey)
        {
            var dbResult = await entiteSet.FindAsync(primaryKey);

            return dbResult;
        }

        public Task Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
