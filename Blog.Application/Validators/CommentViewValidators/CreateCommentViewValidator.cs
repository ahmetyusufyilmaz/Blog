using Blog.Application.ViewModels.CommentViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Application.Validators.CommentViewValidators
{
    public class CreateCommentViewValidator: AbstractValidator<CreateCommentModel>
    {
        public CreateCommentViewValidator()
        {
            RuleFor(vm => vm.UserDto).NotNull();
            RuleFor(vm => vm.Title).NotNull().MaximumLength(100);
            RuleFor(vm => vm.Body).MaximumLength(500);
            RuleFor(vm => vm.Published == true);
        }
    }
}
