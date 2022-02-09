using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public User User { get; set; }
        [Required]
        [MaxLength(150)]
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string Slug { get; set; }
        [MaxLength(300)]
        public string Summary { get; set; }
        public bool Published { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime PublishedAt { get; set; }
        [Required]
        public string Content { get; set; }

    }
}
