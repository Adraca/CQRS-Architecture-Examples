using BlogAPI.Models;
using BlogAPI.Repositories.Articles;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly IArticleRepository _repository;

        public ArticlesController(IArticleRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Add a new article
        /// </summary>
        /// <param name="article">The article to add</param>
        [HttpPost]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public void AddArticle([FromBody]Article article)
        {
            _repository.AddArticle(article);
        }

        /// <summary>
        /// Update an existing article
        /// </summary>
        /// <param name="article">The article to update</param>
        [HttpPut]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public void UpdateArticle([FromBody]Article article)
        {
            _repository.UpdateArticle(article);
        }

        /// <summary>
        /// Get all the articles
        /// </summary>
        /// <returns>The 5 latest articles</returns>
        [HttpGet]
        [ProducesResponseType(typeof(IEnumerable<Article>), 200)]
        [ProducesResponseType(500)]
        public async Task<IEnumerable<Article>> Get()
        {
            return await _repository.FindLatestArticles();
        }

        /// <summary>
        /// Get a specific article
        /// </summary>
        /// <param name="idArticle">The identifier of this article</param>
        /// <returns>The article</returns>
        [HttpGet("{articleId}")]
        [ProducesResponseType(typeof(Article), 200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<Article>> Get(int idArticle)
        {
            return await _repository.FindById(idArticle);
        }

        /// <summary>
        /// Delete a specific article
        /// </summary>
        /// <param name="idArticle">The identifier of the article to delete</param>
        [HttpDelete("{articleId}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
        public void DeleteArticle(int idArticle)
        {
            _repository.DeleteArticle(idArticle);
        }

        /// <summary>
        /// Find all articles of a precise author
        /// </summary>
        /// <param name="authorId">The identifier for this author</param>
        /// <returns>A list of articles</returns>
        [HttpGet("Author/{authorId}")]
        [ProducesResponseType(typeof(IEnumerable<Article>), 200)]
        [ProducesResponseType(500)]
        public async Task<IEnumerable<Article>> AuthorArticles(int authorId)
        {
            return await _repository.FindByAuthor(authorId);
        }
    }
}