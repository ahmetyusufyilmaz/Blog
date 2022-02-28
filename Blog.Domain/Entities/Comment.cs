using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Blog.Domain.Common;

namespace Blog.Domain.Entities
{
    public class Comment : BaseEntity
    {
        public Comment()
        {
            CreatedAt = DateTime.Parse(DateTime.Now.ToShortDateString());
            IsActive = true;
        }

        [Required]
        public User User { get; set; }
        [Required]
        public Post Post { get; set; }
        [Required]
        [MaxLength(100)]
        public string Title { get; set; }
        public bool Published { get; set; }
        public DateTime PublishedAt { get; set; }
        [MaxLength(500)]
        public string Body { get; set; }
    }

}
