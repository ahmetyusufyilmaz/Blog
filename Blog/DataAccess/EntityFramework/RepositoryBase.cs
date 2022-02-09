using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Blog.Entities;
using Blog.Models;

namespace Blog.DataAccess.EntityFramework
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
         where TEntity : IEntity
    {
        private readonly BlogContext _dbcontext;

        public RepositoryBase(BlogContext context)
        {
            _dbcontext = context;

        }

        public bool Add(TEntity entity)
        {
            _dbcontext.Set<TEntity>().Add(entity);
            return _dbcontext.SaveChanges() > 0 ? true : false;
           
        }

        public bool Delete(TEntity entity)
        {
             _dbcontext.Set<TEntity>().Remove(entity);
             return _dbcontext.SaveChanges() > 0 ? true : false;
            
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
             return _dbcontext.Set<TEntity>().SingleOrDefault(filter);
           
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            return _dbcontext.Set<TEntity>().ToList();
        }

        public bool Update(TEntity entity)
        {
            _dbcontext.Set<TEntity>().Update(entity);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }
    }
}

