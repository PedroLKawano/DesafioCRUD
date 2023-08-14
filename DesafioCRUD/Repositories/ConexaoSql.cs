using Microsoft.Data.SqlClient;
using System.Data;

namespace DesafioCRUD.Repositories
{
    public static class ConexaoSql
    {
        public static IDbConnection ObterConexao()
        {
            return new SqlConnection("Data Source=Pedro;Initial Catalog=DesafioCRUD;User ID=sa;Password=DatabaseCRUDC#;TrustServerCertificate=True");            
        }
    }
}