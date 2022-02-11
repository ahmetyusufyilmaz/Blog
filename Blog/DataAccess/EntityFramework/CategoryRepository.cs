using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.DataAccess.EntityFramework
{
    public class CategoryRepository : ICategoryRepository

    {
        private readonly BlogContext _dbcontext;

        public CategoryRepository(BlogContext context)
        {
            _dbcontext = context;

        }

        public bool Add(Category category)
        {
            _dbcontext.Categories.Add(category);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }

        public bool Delete(Category category)
        {
            _dbcontext.Categories.Remove(category);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }

        public Category Get(Expression<Func<Category, bool>> filter)
        {
            return _dbcontext.Categories.Include("Tags").Include("Categories").SingleOrDefault(filter);
        }

        public List<Category> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null ? _dbcontext.Categories.Include("Tags").Include("Categories").ToList() : _dbcontext.Categories.Include("Tags").Include("Categories").Where(filter).ToList();
        }

        public bool Update(Category category)
        {
            _dbcontext.Categories.Update(category);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }
    }
}


