using Blog.Domain.Models;

using Dapper;

using Microsoft.Extensions.Configuration;

using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories.Articles
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
                dbConnection.Open();
                dbConnection.ExecuteAsync(
                    Constants.SPNewArticle,
                    new
                    {
                        article.Title,
                        article.Content,
                        article.CreationDate,
                        IdAuthor = article.AuthorId
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }

        public void DeleteArticle(int idArticle)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.ExecuteAsync(Constants.SPDeleteArticle, new { Id = idArticle }, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<IEnumerable<Article>> FindByAuthor(int idAuthor)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return await dbConnection.QueryAsync<Article>(Constants.SPGetAuthorArticles, new { Id = idAuthor }, commandType: CommandType.StoredProcedure);
            }
        }

        public async Task<Article> FindById(int idArticle)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var result = await dbConnection.QueryAsync<Article>(Constants.SPGetArticle, new { Id = idArticle }, commandType: CommandType.StoredProcedure);

                return result.FirstOrDefault();
            }
        }

        public async Task<IEnumerable<Article>> FindLatestArticles()
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                return await dbConnection.QueryAsync<Article>(Constants.SPLatestArticles, commandType: CommandType.StoredProcedure);
            }
        }

        public void UpdateArticle(Article article)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                dbConnection.ExecuteAsync(
                    Constants.SPUpdateArticle,
                    new
                    {
                        article.Id,
                        article.Title,
                        article.Content
                    },
                    commandType: CommandType.StoredProcedure);
            }
        }
    }
}
