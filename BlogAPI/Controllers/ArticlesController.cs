using BlogAPI.Models;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        /// <summary>
        /// Add a new article
        /// </summary>
        /// <param name="article">The article to add</param>
        [HttpPost]
        public void AddArticle([FromBody]Article article)
        {

        }

        /// <summary>
        /// Update an existing article
        /// </summary>
        /// <param name="article">The article to update</param>
        [HttpPut]
        public void UpdateArticle([FromBody]Article article)
        {

        }

        /// <summary>
        /// Get all the articles
        /// </summary>
        /// <returns>The 5 latest articles</returns>
        [HttpGet]
        public IReadOnlyCollection<Article> Get()
        {
            return new List<Article>();
        }

        /// <summary>
        /// Get a specific article
        /// </summary>
        /// <param name="idArticle">The identifier of this article</param>
        /// <returns>The article</returns>
        [HttpGet("{articleId}")]
        public Article Get(int idArticle)
        {
            return new Article();
        }

        [HttpDelete("{articleId}")]
        public void DeleteArticle([FromQuery]int idArticle)
        {

        }

        /// <summary>
        /// Find all articles of a precise author
        /// </summary>
        /// <param name="authorId">The identifier for this author</param>
        /// <returns>A list of articles</returns>
        [HttpGet("{authorId}")]
        public IReadOnlyCollection<Article> AuthorArticles([FromQuery]int authorId)
        {
            return new List<Article>();
        }
    }
}