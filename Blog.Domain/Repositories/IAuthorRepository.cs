using System.Threading.Tasks;

namespace Blog.Domain.Repositories
{
    public interface IAuthorRepository
    {
        Task<Author> FindById(int idAuthor);
    }
}
