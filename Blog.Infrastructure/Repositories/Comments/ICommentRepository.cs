using Blog.Infrastructure.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories.Comments
{
    public interface ICommentRepository
    {
        void AddComment(Comment comment);
        Task<IEnumerable<Comment>> FindAllByArticle(int idArticle);
    }
}
