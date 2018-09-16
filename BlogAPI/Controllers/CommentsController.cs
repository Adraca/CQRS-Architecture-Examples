using BlogAPI.Models;
using BlogAPI.Repositories;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentRepository _repository;

        public CommentsController(ICommentRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Add a new comment
        /// </summary>
        /// <param name="comment">The comment to add</param>
        [HttpPost]
        public void AddComment([FromBody]Comment comment)
        {
            _repository.AddComment(comment);
        }

        /// <summary>
        /// Get all comments for a specific article
        /// </summary>
        /// <param name="idArticle">The article identifier</param>
        /// <returns>A list of comments</returns>
        [HttpGet]
        public async Task<IEnumerable<Comment>> Get([FromQuery]int idArticle)
        {
            return await _repository.FindAllByArticle(idArticle);
        }
    }
}