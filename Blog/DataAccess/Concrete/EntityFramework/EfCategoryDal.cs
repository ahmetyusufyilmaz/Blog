using Blog.DataAccess.Abstract;
using Blog.DataAccess.EntityFramework;
using Blog.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : RepositoryBase<Category>, ICategoryDal
    {
    }
}
