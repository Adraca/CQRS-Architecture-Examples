using BlogAPI.Models;

using Microsoft.AspNetCore.Mvc;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        /// <summary>
        /// Get all articles of an author
        /// </summary>
        /// <param name="AuthorId">The identifier of the author</param>
        /// <returns>The author</returns>
        [HttpGet("{authorId}")]
        public Author Get([FromQuery]int AuthorId)
        {
            return new Author();
        }
    }
}