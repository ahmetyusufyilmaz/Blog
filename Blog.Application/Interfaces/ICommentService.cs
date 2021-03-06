using Blog.Application.Dto;
using Blog.Application.ViewModels.CommentViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Blog.Application.Interfaces
{
    public interface ICommentService
    {
        List<GetCommentModel> GetAll(Expression<Func<CommentDto, bool>> filter = null);
        GetCommentModel Get(Expression<Func<CommentDto, bool>> filter);
        bool Add(CreateCommentModel createCommentModel);
        bool Update(int id, UpdateCommentModel updateCommentModel);
        bool Delete(DeleteCommentModel deleteCommentModel);
    }
}
