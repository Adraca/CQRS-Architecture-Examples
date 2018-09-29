using System;

namespace Blog.Infrastructure.Models
{
    /// <summary>
    /// Represents the author of an article
    /// </summary>
    public class Author
    {
        /// <summary>
        /// The unique identifier of the author
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of this author, well, most of them use pseudonyms anyway
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The date when the author joined this glorious website
        /// </summary>
        public DateTime RegisterDate { get; set; }
    }
}
