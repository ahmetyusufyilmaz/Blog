using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Blog.DataAccess.EntityFramework
{
    public class TagRepository:ITagRepository
    {
        private readonly BlogContext _dbcontext;

        public TagRepository(BlogContext context)
        {
            _dbcontext = context;

        }

        public bool Add(Tag tag)
        {
            _dbcontext.Tags.Add(tag);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }

        public bool Delete(Tag tag)
        {
            _dbcontext.Tags.Remove(tag);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }

        public Tag Get(Expression<Func<Tag, bool>> filter)
        {
            return _dbcontext.Tags.Include("Tags").Include("Categories").SingleOrDefault(filter);
        }

        public List<Tag> GetAll(Expression<Func<Tag, bool>> filter = null)
        {
            return filter == null ? _dbcontext.Tags.Include("Tags").Include("Categories").ToList() : _dbcontext.Tags.Include("Tags").Include("Categories").Where(filter).ToList();
        }

        public bool Update(Tag tag)
        {
            _dbcontext.Tags.Update(tag);
            return _dbcontext.SaveChanges() > 0 ? true : false;
        }
    }
}

