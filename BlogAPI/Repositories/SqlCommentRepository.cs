using BlogAPI.Models;

using Dapper;

using Microsoft.Extensions.Configuration;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace BlogAPI.Repositories
{
    public class SqlCommentRepository : ICommentRepository
    {
        private readonly IConfiguration _config;

        public SqlCommentRepository(IConfiguration config)
        {
            _config = config;
        }

        private IDbConnection Connection
        {
            get
            {
                return new SqlConnection(_config.GetConnectionString("BlogDatabase"));
            }
        }

        public void AddComment(Comment comment)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "INSERT INTO Comment (Id, Content, CreationDate, AuthorName, ArticleId) VALUES (@newComment)";
                dbConnection.Open();
                dbConnection.ExecuteAsync(query, new { newComment = comment });
            }
        }

        public async Task<IEnumerable<Comment>> FindAllByArticle(int idArticle)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "SELECT * FROM Comment WHERE IdArticle = @Id";
                dbConnection.Open();
                return await dbConnection.QueryAsync<Comment>(query, new { Id = idArticle });
            }
        }
    }
}
