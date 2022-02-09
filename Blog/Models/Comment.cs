using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Models
{
    public class Comment
    {  
            public int Id { get; set; }
            [Required]
            public Post Post { get; set; }
            [Required]
            [MaxLength(100)]
            public string Title { get; set; }
            public bool Published { get; set; }
            public DateTime CreatedAt { get; set; }
            public DateTime PublishedAt { get; set; }
            [MaxLength(500)]
            public string Context { get; set; }
    
    }
}
