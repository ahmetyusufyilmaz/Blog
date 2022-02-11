using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.DataAccess
{
    public interface ICategoryRepository
    {
        List<Category> GetAll(Expression<Func<Category, bool>> filter = null);

        Category Get(Expression<Func<Category, bool>> filter);

        bool Add(Category category);
        bool Update(Category category);
        bool Delete(Category category);
    }
}
