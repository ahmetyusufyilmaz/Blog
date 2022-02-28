using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blog.Domain.Common;

namespace Blog.Domain.Entities
{
    public class Tag : BaseEntity
    {
        public Tag()
        {
            CreatedAt = DateTime.Parse(DateTime.Now.ToShortDateString());
            IsActive = true;
        }

        [Required]
        [MaxLength(75)]
        public string Title { get; set; }
        public string MetaTitle { get; set; }
        [Required]
        public string Body { get; set; }
        public virtual ICollection<Post> Posts { get; set; }

    }
}
