using Blog.Application.Dto;
using Blog.Application.ViewModels.PostViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.ViewModels.CommentViewModels
{
    public class GetCommentModel
    {

        public UserDto User { get; set; }
        public GetPostModel Post { get; set; }
        public string Title { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Body { get; set; }
    }
}
