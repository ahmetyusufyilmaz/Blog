using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Dto
{
    public class CommentDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public UserDto User { get; set; }
    }
}
