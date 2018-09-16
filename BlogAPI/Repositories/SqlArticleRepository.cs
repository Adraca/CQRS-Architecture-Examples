using BlogAPI.Models;

using Dapper;

using Microsoft.Extensions.Configuration;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAPI.Repositories
{
    public class SqlArticleRepository : IArticleRepository
    {
        private readonly IConfiguration _config;

        public SqlArticleRepository(IConfiguration config)
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

        public void AddArticle(Article article)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "INSERT INTO Article (Id, Title, Content, CreationDate, AuthorId) VALUES (@newArticle)";
                dbConnection.Open();
                dbConnection.ExecuteAsync(query, new { newArticle = article });
            }
        }

        public void DeleteArticle(int idArticle)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "DELETE FROM Article WHERE Id = @Id";
                dbConnection.Open();
                dbConnection.ExecuteAsync(query, new { Id = idArticle });
            }
        }

        public async Task<IEnumerable<Article>> FindByAuthor(int idAuthor)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "SELECT * FROM Article WHERE IdAuthor = @Id";
                dbConnection.Open();
                return await dbConnection.QueryAsync<Article>(query, new { Id = idAuthor });
            }
        }

        public async Task<Article> FindById(int idArticle)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "SELECT * FROM Article WHERE Id = @Id";
                dbConnection.Open();
                var result = await dbConnection.QueryAsync<Article>(query, new { Id = idArticle });

                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Article>> FindLatestArticles()
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "SELECT TOP 5 * FROM Article ORDER BY Date ASC";
                dbConnection.Open();
                return await dbConnection.QueryAsync<Article>(query);
            }
        }

        public void UpdateArticle(Article article)
        {
            using (IDbConnection dbConnection = Connection)
            {
                string query = "UPDATE Article @updateArticle SET WHERE Id = @Id";
                dbConnection.Open();
                dbConnection.ExecuteAsync(query, new { updateArticle = article, Id = article.Id });
            }
        }
    }
}
