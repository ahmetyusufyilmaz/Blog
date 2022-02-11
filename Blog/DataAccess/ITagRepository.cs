using Blog.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.DataAccess
{
    public interface ITagRepository<TEntity> where TEntity : IEntity
    {
        List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null);

        TEntity Get(Expression<Func<TEntity, bool>> filter);

        bool Add(TEntity entity);
        bool Update(TEntity entity);
        bool Delete(TEntity entity);
    }
}