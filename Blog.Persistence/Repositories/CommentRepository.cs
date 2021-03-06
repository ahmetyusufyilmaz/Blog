
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
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(UserDbContext context) : base(context)
        {

        }
        public async override Task<Comment> Get(Expression<Func<Comment, bool>> filter)
        {
            return await _dbcontext.Comments.Include(c => c.Post).SingleOrDefaultAsync(filter);
        }

        public async override Task<List<Comment>> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            return filter == null ? await _dbcontext.Comments.Include(c => c.Post).ToListAsync() : await _dbcontext.Comments.Include(c => c.Post).Where(filter).ToListAsync();
        }
    }
}

 
