using System;

namespace Blog.Domain
{
    /// <summary>
    /// Represents the article
    /// </summary>
    public class Article
    {
        /// <summary>
        /// The unique identifier of this Article
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The title, should be as click-bait as possible
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Here is the real content of the article, it's what it truly is
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The date at which this article was added
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// The unique identifier for the author who wrote the article
        /// </summary>
        public int AuthorId { get; set; }
    }
}
