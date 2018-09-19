using System;

namespace BlogAPI.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime CreationDate { get; set; }
        public int AuthorId { get; set; }
        public int ArticleId { get; set; }
    }
}
