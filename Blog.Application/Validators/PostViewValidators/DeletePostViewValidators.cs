using Blog.Application.ViewModels.PostViewModels;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Application.Validators.PostViewValidators
{
    public class DeletePostViewValidators : AbstractValidator<DeletePostModel>
    {
        public DeletePostViewValidators()
        {
            RuleFor(vm => vm.Id).NotEmpty().NotNull();
        }
    }
}


