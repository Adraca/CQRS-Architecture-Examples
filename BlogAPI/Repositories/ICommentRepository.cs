using BlogAPI.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogAPI.Repositories
{
    public interface ICommentRepository
    {
        void AddComment(Comment comment);
        Task<IEnumerable<Comment>> FindAllByArticle(int idArticle);
    }
}
