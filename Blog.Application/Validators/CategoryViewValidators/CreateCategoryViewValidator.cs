using Blog.Application.ViewModels.CategoryViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Application.Validators.CategoryViewValidators
{
    public class CreateCategoryViewValidator : AbstractValidator<CreateCategoryModel>
    {
        public CreateCategoryViewValidator()
        {
            RuleFor(vm => vm.Title).NotNull().NotEmpty().MaximumLength(50);
            RuleFor(vm => vm.Body).NotNull().NotEmpty().MaximumLength(300);
            RuleFor(vm => vm.MetaTitle).NotNull().NotEmpty().MaximumLength(50);
    }
    }
}
