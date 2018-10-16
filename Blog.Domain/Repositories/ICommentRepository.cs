using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Domain.Repositories
{
    public interface ICommentRepository
    {
        Task AddComment(Comment comment);
        Task<IEnumerable<Comment>> FindAllByArticle(int idArticle);
    }
}
