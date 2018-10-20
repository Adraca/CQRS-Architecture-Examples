using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Domain.ArticleAggregate
{
    public interface IArticleRepository
    {
        Task AddArticle(Article article);
        Task UpdateArticle(Article article);
        Task DeleteArticle(int idArticle);
        Task<Article> FindById(int idArticle);
        Task<IEnumerable<Article>> FindLatestArticles();
        Task<IEnumerable<Article>> FindByAuthor(int idAuthor);
    }
}
