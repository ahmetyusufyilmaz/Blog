using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.DataAccess.EntityFramework
{
    public class CommentRepository : ICommentRepository

    {
        private readonly BlogContext _dbcontext;

        public CommentRepository(BlogContext context)
        {
            _dbcontext = context;

        }

        public bool Add(Comment comment)
        {
            _dbcontext.Comments.Add(comment);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }

        public bool Delete(Comment comment)
        {
            _dbcontext.Comments.Remove(comment);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }

        public Comment Get(Expression<Func<Comment, bool>> filter)
        {
            return _dbcontext.Comments.Include("Tags").Include("Categories").SingleOrDefault(filter);
        }

        public List<Comment> GetAll(Expression<Func<Comment, bool>> filter = null)
        {
            return filter == null ? _dbcontext.Comments.Include("Tags").Include("Categories").ToList() : _dbcontext.Comments.Include("Tags").Include("Categories").Where(filter).ToList();
        }

        public bool Update(Comment comment)
        {
            _dbcontext.Comments.Update(comment);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }
    }
}
{
    }
}
