using Blog.Domain.Models;

using Dapper;

using Microsoft.Extensions.Configuration;

using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;

namespace Blog.Infrastructure.Repositories.Authors
{
    public class SqlAuthorRepository : IAuthorRepository
    {
        private readonly IConfiguration _config;

        public SqlAuthorRepository(IConfiguration config)
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

        public async Task<Author> FindById(int idAuthor)
        {
            using (IDbConnection dbConnection = Connection)
            {
                dbConnection.Open();
                var result = await dbConnection.QueryAsync<Author>(
                    Constants.SPGetAuthor,
                    new { Id = idAuthor },
                    commandType: CommandType.StoredProcedure);
                return result.FirstOrDefault();
            }
        }
    }
}
