using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories
{
    public interface ICommentRepository
    {
        void AddComment(Comment comment);
        Task<IEnumerable<Comment>> FindAllByArticle(int idArticle);
    }
}
