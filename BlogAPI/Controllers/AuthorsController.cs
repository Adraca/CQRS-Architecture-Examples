﻿using BlogAPI.Models;
using BlogAPI.Repositories.Authors;

using Microsoft.AspNetCore.Mvc;

using System.Threading.Tasks;

namespace BlogAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorRepository _repository;

        public AuthorsController(IAuthorRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// Get all articles of an author
        /// </summary>
        /// <param name="AuthorId">The identifier of the author</param>
        /// <returns>The author</returns>
        [HttpGet("{authorId}")]
        [ProducesResponseType(typeof(Author), 200)]
        [ProducesResponseType(500)]
        public async Task<ActionResult<Author>> GetAsync(int AuthorId)
        {
            return await _repository.FindById(AuthorId);
        }
    }
}