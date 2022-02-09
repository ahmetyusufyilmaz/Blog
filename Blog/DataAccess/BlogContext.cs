using Blog.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.DataAccess
{
    public class BlogContext : DbContext
    {

        public BlogContext(DbContextOptions options)
           : base(options)
        {

        }

        public  DbSet<Category> Categories { get; set; }
        public  DbSet<Comment> Comments { get; set; }
        public  DbSet<Post> Posts { get; set; }
        public  DbSet<Tag> Tags { get; set; }
        public  DbSet<User> Users { get; set; }

    }
}
