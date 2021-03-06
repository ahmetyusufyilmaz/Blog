using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.DomainServices
{
    public interface IUnitOfWork : IDisposable
    {
        IPostRepository Posts { get; }
        ICommentRepository Comments { get; }
        ICategoryRepository Categories { get; }
        ITagRepository Tags { get; }
        IUserRepository Users { get; }
        Task<int> Complete();
    }
}
