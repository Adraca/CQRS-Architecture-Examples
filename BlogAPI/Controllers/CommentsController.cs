using BlogAPI.Models;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        /// <summary>
        /// Add a new comment
        /// </summary>
        /// <param name="comment">The comment to add</param>
        [HttpPost]
        public void AddComment([FromBody]Comment comment)
        {

        }

        /// <summary>
        /// Get all comments for a specific article
        /// </summary>
        /// <param name="idArticle">The article identifier</param>
        /// <returns>A list of comments</returns>
        [HttpGet]
        public IReadOnlyCollection<Comment> Get([FromQuery]int idArticle)
        {
            return new List<Comment>();
        }
    }
}