using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;



namespace Blog.DataAccess.EntityFramework
{
    public class PostRepository : IPostRepository

    {
        private readonly BlogContext _dbcontext;

        public PostRepository(BlogContext context)
        {
            _dbcontext = context;

        }

        public bool Add(Post post)
        {
            _dbcontext.Posts.Add(post);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }

        public bool Delete(Post post)
        {
            _dbcontext.Posts.Remove(post);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }

        public Post Get(Expression<Func<Post, bool>> filter)
        {
            return _dbcontext.Posts.Include("Tags").Include("Categories").SingleOrDefault(filter);
        }

        public List<Post> GetAll(Expression<Func<Post, bool>> filter = null)
        {
            return filter == null ? _dbcontext.Posts.Include("Tags").Include("Categories").ToList() : _dbcontext.Posts.Include("Tags").Include("Categories").Where(filter).ToList();
        }

        public bool Update(Post post)
        {
            _dbcontext.Posts.Update(post);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }
    }
}

