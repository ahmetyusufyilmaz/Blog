using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
namespace Blog.Application.ViewModels.PostViewModels
{
    [NotMapped]
    public class DeletePostModel
    {
        public int Id { get; set; }
    }
}
