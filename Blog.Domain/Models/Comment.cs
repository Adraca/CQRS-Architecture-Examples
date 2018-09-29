using System;

namespace Blog.Domain.Models
{
    /// <summary>
    /// Represents the comment
    /// </summary>
    public class Comment
    {
        /// <summary>
        /// The unique identifier for this comment
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The content, where most people can finally say what they want about the article
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// The creation date for this master piece of a critique
        /// </summary>
        public DateTime CreationDate { get; set; }

        /// <summary>
        /// Yes, we still know the authors of the comments, this is not 4chan
        /// </summary>
        public int AuthorId { get; set; }

        /// <summary>
        /// The unique identifier of the article, because we need to know what piece of tr*** article we are commenting on 
        /// </summary>
        public int ArticleId { get; set; }
    }
}
