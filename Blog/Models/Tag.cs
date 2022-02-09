using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blog.Entities;

namespace Blog.Models
{
    public class Tag : IEntity
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(75)]
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        public string Slug { get; set; }
        [Required]
        public string Contents { get; set; }
        public ICollection<Post> Post { get; set; }

    }
}
