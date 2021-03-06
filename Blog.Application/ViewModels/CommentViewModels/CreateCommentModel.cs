using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Blog.Application.Dto;
using Blog.Application;

namespace Blog.Application.ViewModels.CommentViewModels
{
    public class CreateCommentModel
    {
        public UserDto UserDto { get; set; }
   
        public PostDto PostDto { get; set; }
        public string Title { get; set; }
        public bool Published { get; set; }
        public DateTime PublishedAt { get; set; }
        public string Body { get; set; }
    }
}
