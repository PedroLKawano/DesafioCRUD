using Dapper;

namespace DesafioCRUD.Repositories
{
    public class GeneroRepository
    {        
        public void CadastrarGenero(string descricao)
        {
            using (var conexao = ConexaoSql.ObterConexao())
            {
                var generoId = conexao.QueryFirstOrDefault<int>("SELECT Id FROM [Genero] WHERE Descricao = @Descricao", new { Descricao = descricao });

                if (generoId == 0)
                    conexao.Execute("INSERT INTO [Genero] (Descricao) VALUES (@Descricao)", new {Descricao = descricao});             
            }
        }
        public int BuscarGeneroId(string descricao)
        {
            using (var conexao = ConexaoSql.ObterConexao())
            {
                return conexao.QueryFirstOrDefault<int>("SELECT Id FROM [Genero] WHERE Descricao = @Descricao", new { Descricao = descricao });
            }
        }
    }
}
