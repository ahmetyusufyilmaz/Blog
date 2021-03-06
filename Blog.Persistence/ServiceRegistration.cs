
using Blog.DomainServices;
using Blog.Persistence.Context;
using Blog.Persistence.Repositories;
using Blog.Persistence.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Persistence
{
    public static class ServiceRegistration
    {
        public static void AddPersistenceServices(this IServiceCollection services, IConfiguration configuration = null)
        {
            services.AddDbContext<UserDbContext>(opts => opts.UseSqlServer(configuration["ConnectionString:DBBlog"]));
            services.AddScoped<UserDbContext>();

            // Repositories
            services.AddScoped<IPostRepository, PostRepository>();
            services.AddScoped<ICommentRepository, CommentRepository>();
            services.AddScoped<ITagRepository, TagRepository>();
            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            //UnitOfWork
            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
