using Blog.Domain.Repositories;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.Domain
{
    public class ArticleAggregate
    {
        IArticleRepository _repository;

        public ArticleAggregate(IArticleRepository repository)
        {
            _repository = repository;
        }

        public void AddArticle(Article article)
        {
            _repository.AddArticle(article);
        }

        public void UpdateArticle(Article article)
        {
            _repository.UpdateArticle(article);
        }

        public async Task<IEnumerable<Article>> FindLatestArticles()
        {
            return await _repository.FindLatestArticles();
        }

        public async Task<Article> FindById(int idArticle)
        {
            return await _repository.FindById(idArticle);
        }

        public void DeleteArticle(int idArticle)
        {
            _repository.DeleteArticle(idArticle);
        }

        public async Task<IEnumerable<Article>> FindByAuthor(int authorId)
        {
            return await _repository.FindByAuthor(authorId);
        }
    }
}
