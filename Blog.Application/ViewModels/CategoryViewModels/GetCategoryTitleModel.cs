using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Blog.Application.ViewModels.CategoryViewModels
{
    [NotMapped]
    public class GetCategoryTitleModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}
