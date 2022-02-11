using Blog.Entities;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.DataAccess
{
    public interface ITagRepository
    {
        List<Tag> GetAll(Expression<Func<Tag, bool>> filter = null);

        Tag Get(Expression<Func<Tag, bool>> filter);

        bool Add(Tag tag);
        bool Update(Tag tag);
        bool Delete(Tag tag);
    }
}