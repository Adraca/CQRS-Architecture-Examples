using Blog.Domain.Models;

using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories.Authors
{
    public interface IAuthorRepository
    {
        Task<Author> FindById(int idAuthor);
    }
}
