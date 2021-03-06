using Blog.Application;
using Blog.Application.Dto;
using Blog.Application.ViewModels.CategoryViewModels;
using Blog.Application.ViewModels.TagViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.ViewModels.PostViewModels
{
   public class GetPostModel
    {
        public UserDto User { get; set; }
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string Summary { get; set; }
        public bool Published { get; set; }
        public short? Likes { get; set; }
        public short? Dislike { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Body { get; set; }
        public virtual ICollection<GetCategoryTitleModel> Categories { get; set; }
        public virtual ICollection<GetTagTitleModel> Tags { get; set; }
    }
}
