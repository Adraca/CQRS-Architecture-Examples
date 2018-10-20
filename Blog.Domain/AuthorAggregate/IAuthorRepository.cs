using System.Threading.Tasks;

namespace Blog.Domain.AuthorAggregate
{
    public interface IAuthorRepository
    {
        Task<Author> FindById(int idAuthor);
    }
}
