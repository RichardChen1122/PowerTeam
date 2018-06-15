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
        public virtual async Task Delete(T entity)
        {
            if (_ptDbContext.Entry(entity).State == EntityState.Detached)
            {
                entiteSet.Attach(entity);
            }
            dynamic obj = entiteSet.Remove(entity);
            await this._ptDbContext.SaveChangesAsync();
        }

        public bool Exists(Guid primaryKey)
        {
            return entiteSet.Find(primaryKey) == null ? false : true;
        }

        public IQueryable<T> GetAll()
        {
            return entiteSet.AsQueryable();
        }

        public virtual async Task Insert(T entity)
        {
            dynamic obj = entiteSet.Add(entity);
            await this._ptDbContext.SaveChangesAsync();
        }

        public virtual async Task<T> Single(Guid primaryKey)
        {
            var dbResult = await entiteSet.FindAsync(primaryKey);

            return dbResult;
        }

        public virtual async Task Update(T entity)
        {
            _ptDbContext.Entry(entity).State = EntityState.Modified;

            await this._ptDbContext.SaveChangesAsync();
        }
    }
}
