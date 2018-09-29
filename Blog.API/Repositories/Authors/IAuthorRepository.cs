using Blog.API.Models;

using System.Threading.Tasks;

namespace Blog.API.Repositories.Authors
{
    public interface IAuthorRepository
    {
        Task<Author> FindById(int idAuthor);
    }
}
