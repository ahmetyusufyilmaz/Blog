using Blog.Entities;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.DataAccess
{
    public interface IPostRepository
    {
        List<Post> GetAll(Expression<Func<Post, bool>> filter = null);
        Post Get(Expression<Func<Post, bool>> filter);
        bool Add(Post post);
        bool Update(Post post);
        bool Delete(Post post);
    }
}
