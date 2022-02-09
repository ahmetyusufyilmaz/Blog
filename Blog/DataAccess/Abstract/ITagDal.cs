using Blog.DataAccess.EntityFramework;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DataAccess.Abstract
{
    public interface ITagDal : IRepositoryBase<Tag>
    {
    }
}
