using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.DataAccess
{
    public interface ICommentRepository
    {
        List<Comment> GetAll(Expression<Func<Comment, bool>> filter = null);

        Comment Get(Expression<Func<Category, bool>> filter);

        bool Add(Comment category);
        bool Update(Comment category);
        bool Delete(Comment category);
    }
}
