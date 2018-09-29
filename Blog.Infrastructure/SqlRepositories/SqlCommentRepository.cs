using Blog.Domain;
using Blog.Domain.Repositories;

using Dapper;

using Microsoft.Extensions.Configuration;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;

namespace Blog.Infrastructure.SqlRepositories
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
                dbConnection.Open();
                dbConnection.ExecuteAsync(
                    Constants.SPNewComment,
                    new
                    {
                        comment.Content,
                        comment.CreationDate,
                        IdAuthor = comment.AuthorId,
                        IdArticle = comment.ArticleId
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<Comment>> FindAllByArticle(int idArticle)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return await dbConnection.QueryAsync<Comment>(
                    Constants.SPGetComments,
                    new { Id = idArticle },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
