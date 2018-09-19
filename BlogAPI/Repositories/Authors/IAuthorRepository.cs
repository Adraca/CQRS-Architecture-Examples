using BlogAPI.Models;

using System.Threading.Tasks;

namespace BlogAPI.Repositories.Authors
{
    public interface IAuthorRepository
    {
        Task<Author> FindById(int idAuthor);
    }
}
