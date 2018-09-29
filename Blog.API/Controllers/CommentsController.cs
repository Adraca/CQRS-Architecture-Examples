using Blog.Domain;
using Blog.Domain.Repositories;

using Microsoft.AspNetCore.Mvc;

using System.Collections.Generic;
using System.Threading.Tasks;

namespace Blog.API.Controllers
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
        [ProducesResponseType(200)]
        [ProducesResponseType(500)]
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
        [ProducesResponseType(typeof(IEnumerable<Comment>), 200)]
        [ProducesResponseType(500)]
        public async Task<IEnumerable<Comment>> Get(int idArticle)
        {
            return await _repository.FindAllByArticle(idArticle);
        }
    }
}