using Entity.IModels;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Repository.Service.Base
{
    public abstract class BaseService<T> : IBaseService<T> where T : class, IEntity
    {
        protected DbContext Db;
        protected BaseService(DbContext _Db)
        {
            Db = _Db;
        }
        public bool Add(T entity)
        {
            throw new NotImplementedException();
        }

        protected DbSet<T> DbSet => Db.Set<T>();

        public virtual async Task<bool> AddAsync(T entity)
        {
            DbSet.Add(entity);
            return await Db.SaveChangesAsync() > 0;
        }

        public virtual bool AddRange(ICollection<T> entities)
        {
            DbSet.AddRange(entities);
            return Db.SaveChanges() > 0;
        }

        public virtual void Dispose()
        {
            Db?.Dispose();
        }

        public virtual IEnumerable<T> GetAll()
        {
            return DbSet.ToList();
        }

        public async virtual Task<IEnumerable<T>> GetAllAsync()
        {
            return await DbSet.ToListAsync();

        }

        public virtual T GetById(long id)
        {
            return DbSet.FirstOrDefault(x => x.Id == id);
        }

        public async virtual Task<T> GetByIdAsync(long id)
        {
            return await DbSet.FirstOrDefaultAsync(x => x.Id == id);
        }

        public virtual int GetCount()
        {
            return DbSet.Count();
        }

        public async virtual Task<int> GetCountAsync()
        {
            return await DbSet.CountAsync();
        }

        public virtual bool Remove(T entity)
        {
            if (entity == null)
            {
                return false;
            }
            try
            {
                DbSet.Remove(entity);
                return Db.SaveChanges() > 0;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public virtual bool RemoveRange(ICollection<T> entities)
        {
            bool isDeleted = false;
            if(entities != null && entities.Count > 0)
            {
                DbSet.RemoveRange(entities);
                isDeleted = Db.SaveChanges() > 0;
            }
            return isDeleted;
        }

        public virtual bool Update(T entity)
        {
            DbSet.Update(entity);
            return Db.SaveChanges() > 0;
        }

        public virtual bool UpdateRange(ICollection<T> entities)
        {
            DbSet.UpdateRange(entities);
            return Db.SaveChanges() > 0;
        }
        
    }
}
