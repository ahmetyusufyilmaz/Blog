using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Blog.Application.ViewModels.PostViewModels;

namespace Blog.Application.ViewModels.TagViewModels
{
    public class GetTagModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public virtual ICollection<GetPostModel> Posts { get; set; }
    }
}
