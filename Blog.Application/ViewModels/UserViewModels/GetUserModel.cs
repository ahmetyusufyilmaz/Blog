using Blog.Application.ViewModels.PostViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.ViewModels.UserViewModels
{
    public class GetUserModel
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Intro { get; set; }
        public virtual ICollection<GetPostModel> Posts { get; set; }
    }
}
