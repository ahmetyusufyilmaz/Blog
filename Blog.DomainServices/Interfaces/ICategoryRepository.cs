using Blog.Domain.Entities;
using Blog.DomainServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DomainServices
{
    public interface ICategoryRepository : IRepository<Category>
    {

    }
}
