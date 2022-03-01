using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;
using Blog.Persistence.Context;
using Blog.Domain.Entities;
using Blog.DomainServices;

namespace Blog.Persistence.Repositories
{ 
    public class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(UserDbContext context) : base(context)
        {

        }
        public async override Task<Tag> Get(Expression<Func<Tag, bool>> filter)
        {
            return await _dbcontext.Tags.Include(c => c.Posts).SingleOrDefaultAsync(filter);
        }

        public async override Task<List<Tag>> GetAll(Expression<Func<Tag, bool>> filter = null)
        {
            return filter == null ? await _dbcontext.Tags.Include(c => c.Posts).ToListAsync() : await _dbcontext.Tags.Include(c => c.Posts).Where(filter).ToListAsync();
        }
    }

}

