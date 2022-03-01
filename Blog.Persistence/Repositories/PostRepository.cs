using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Blog.Domain.Entities;
using Blog.Persistence.Context;
using Blog.DomainServices;

namespace Blog.Persistence.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(UserDbContext context) : base(context)
        {

        }
        public async override Task<Post> Get(Expression<Func<Post, bool>> filter)
        {
            return await _dbcontext.Posts.Include(c => c.Tags).Include(c => c.Categories).SingleOrDefaultAsync(filter);
        }
        public async override Task<List<Post>> GetAll(Expression<Func<Post, bool>> filter = null)
        {
            return filter == null ? await _dbcontext.Posts.Include(c => c.Tags).Include(c => c.Categories).ToListAsync() : await _dbcontext.Posts.Include(c => c.Tags).Include(c => c.Categories).Where(filter).ToListAsync();
        }
    }
}
