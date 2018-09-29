using Blog.API.Models;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.API.Repositories.Articles
{
    public interface IArticleRepository
    {
        void AddArticle(Article article);
        void UpdateArticle(Article article);
        void DeleteArticle(int idArticle);
        Task<Article> FindById(int idArticle);
        Task<IEnumerable<Article>> FindLatestArticles();
        Task<IEnumerable<Article>> FindByAuthor(int idAuthor);

    }
}
