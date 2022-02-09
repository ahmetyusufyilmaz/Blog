using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Blog.Entities;

namespace Blog.DataAccess.EntityFramework
{
    public class RepositoryBase<TEntity, TContext> : IRepositoryBase<TEntity>
      where TEntity : IEntity
    {
        private readonly BlogContext _dbcontext;

        public RepositoryBase(BlogContext context)
        {
            _dbcontext = context;

        }

        public bool Add(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public bool Delete(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public bool Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}

