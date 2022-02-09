using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public class Category
    {
            public int Id { get; set; }
            [Required]
            [MaxLength(50)]
            public string Title { get; set; }
            [MaxLength(50)]
            public string MetaTitle { get; set; }
            public string Slug { get; set; }
            [MaxLength(300)]
            public string Content { get; set; }
            ICollection<Post> posts { get; set; }


    }
}
