using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blog.Domain.Common;

namespace Blog.Domain.Entities
{
    public class Category :BaseEntity
    {
        public Category()
        {
            CreatedAt = DateTime.Parse(DateTime.Now.ToShortDateString());
            IsActive = true;
        }

        [Required]
        [MaxLength(50)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string MetaTitle { get; set; }

        [MaxLength(300)]
        public string Body { get; set; }
        public virtual ICollection<Post> Posts { get; set; }


    }
}
