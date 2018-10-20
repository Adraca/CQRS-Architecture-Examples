using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Domain.CommentAggregate
{
    public interface ICommentRepository
    {
        Task AddComment(Comment comment);
        Task<IEnumerable<Comment>> FindAllByArticle(int idArticle);
    }
}
