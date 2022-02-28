using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Blog.Persistence.Context;
using Blog.Application.Interfaces;

namespace Blog.Persistence.Repositories
{
    public class RepositoryBase<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly UserDbContext _dbcontext;
        public RepositoryBase(UserDbContext dbContext)
        {
            _dbcontext = dbContext;
        }
        public void Add(TEntity entity)
        {
            _dbcontext.Set<TEntity>().Add(entity);
        }

        public virtual void Delete(TEntity entity)
        {
            _dbcontext.Set<TEntity>().Remove(entity);
        }

        public virtual async Task<TEntity> Get(Expression<Func<TEntity, bool>> filter)
        {

            return await _dbcontext.Set<TEntity>().Where(filter).SingleOrDefaultAsync();
        }

        public virtual async Task<List<TEntity>> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return filter == null ? await _dbcontext.Set<TEntity>().ToListAsync() : await _dbcontext.Set<TEntity>().Where(filter).ToListAsync();
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await _dbcontext.Set<TEntity>().FindAsync(id);
        }

        public virtual void Update(TEntity entity)
        {
            _dbcontext.Set<TEntity>().Update(entity);
        }
    }
}

