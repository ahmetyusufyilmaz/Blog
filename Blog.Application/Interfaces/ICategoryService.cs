using Blog.Application.Dto;
using Blog.Application.ViewModels.CategoryViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Application.Interfaces
{
    public interface ICategoryService
    {
        List<GetCategotyViewModel> GetAll(Expression<Func<CategoryDto, bool>> filter = null);
        GetCategoryTitleModel Get(Expression<Func<CategoryDto, bool>> filter);
        bool Add(CreateCategoryModel createCategoryModel);
        bool Update(int id, UpdateCategoryModel updateCategoryModel);
        bool Delete(DeleteCategoryModel deleteCategoryModel);
    }
}
