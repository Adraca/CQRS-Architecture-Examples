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
        public void AddArticle([FromBody]Article article)
        {
            _repository.AddArticle(article);
        }

        /// <summary>
        /// Update an existing article
        /// </summary>
        /// <param name="article">The article to update</param>
        [HttpPut]
        public void UpdateArticle([FromBody]Article article)
        {
            _repository.UpdateArticle(article);
        }

        /// <summary>
        /// Get all the articles
        /// </summary>
        /// <returns>The 5 latest articles</returns>
        [HttpGet]
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
        public async Task<ActionResult<Article>> Get(int idArticle)
        {
            return await _repository.FindById(idArticle);
        }

        [HttpDelete("{articleId}")]
        public void DeleteArticle([FromQuery]int idArticle)
        {
            _repository.DeleteArticle(idArticle);
        }

        /// <summary>
        /// Find all articles of a precise author
        /// </summary>
        /// <param name="authorId">The identifier for this author</param>
        /// <returns>A list of articles</returns>
        [HttpGet("{authorId}")]
        public async Task<IEnumerable<Article>> AuthorArticles([FromQuery]int authorId)
        {
            return await _repository.FindByAuthor(authorId);
        }
    }
}