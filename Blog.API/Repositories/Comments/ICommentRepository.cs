using Blog.API.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.API.Repositories.Comments
{
    public interface ICommentRepository
    {
        void AddComment(Comment comment);
        Task<IEnumerable<Comment>> FindAllByArticle(int idArticle);
    }
}
