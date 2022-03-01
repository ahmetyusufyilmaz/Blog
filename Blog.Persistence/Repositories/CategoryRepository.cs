
using Blog.Domain.Entities;
using Blog.DomainServices;
using Blog.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.Persistence.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(UserDbContext context) : base(context)
        {

        }
        public async override Task<Category> Get(Expression<Func<Category, bool>> filter)
        {
            return await _dbcontext.Categories.Include(c => c.Posts).SingleOrDefaultAsync(filter);
        }

        public async override Task<List<Category>> GetAll(Expression<Func<Category, bool>> filter = null)
        {
            return filter == null ? await _dbcontext.Categories.Include(c => c.Posts).ToListAsync() : await _dbcontext.Categories.Include(c => c.Posts).Where(filter).ToListAsync();
        }
    }
}
