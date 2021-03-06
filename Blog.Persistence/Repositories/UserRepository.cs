
using Blog.Domain.Entities;
using Blog.DomainServices;
using Blog.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Persistence.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(UserDbContext context) : base(context)
        {

        }
        public async override Task<User> Get(Expression<Func<User, bool>> filter)
        {
            return await _dbcontext.Users.Include(u => u.Posts).SingleOrDefaultAsync(filter);
        }

        public async override Task<List<User>> GetAll(Expression<Func<User, bool>> filter = null)
        {
            return filter == null ? await _dbcontext.Users.Include(u => u.Posts).ToListAsync() : await _dbcontext.Users.Include(c => c.Posts).Where(filter).ToListAsync();
        }
    }
}
