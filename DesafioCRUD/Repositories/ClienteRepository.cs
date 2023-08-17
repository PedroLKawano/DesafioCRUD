using Dapper;
using DesafioCRUD.Models;

namespace DesafioCRUD.Repositories
{
    public class ClienteRepository
    {
        public IEnumerable<ClienteGenero> ListarClientes(int? codigo, string? nome, int? idade, string? descricaoGenero)
        {
            try 
            {
                using (var conexao = ConexaoSql.ObterConexao())
                {
                    string consulta = @"SELECT c.Id, c.Nome, c.Sobrenome, g.Descricao AS DescricaoGenero, c.DataNascimento, c.Endereco, c.Numero, c.Cep, c.Bairro
                    FROM [CLIENTE] C INNER JOIN [GENERO] G ON c.GeneroId = g.Id";

                    if (codigo.HasValue)                    
                        consulta += " WHERE c.ID = @Codigo";
                    if (!string.IsNullOrEmpty(nome))
                        consulta += " AND c.Nome + ' ' + c.Sobrenome LIKE @Nome";

                    DateTime? dataMaxima = null;
                    DateTime? dataMinima = null;

                    if (idade.HasValue)
                    {
                        dataMaxima = DateTime.Now.AddYears(-idade.Value);
                        dataMinima = dataMaxima.Value.AddYears(-1);
                        consulta += " AND c.DataNascimento > @DataMinima AND c.DataNascimento <= @DataMaxima";
                    } 
                    
                    if (!string.IsNullOrEmpty(descricaoGenero))
                        consulta += " AND g.Descricao LIKE @Descricao";

                    return conexao.Query<ClienteGenero>(consulta + " AND ELIMINADO = 0 ORDER BY c.Nome",
                        new
                        {
                            Codigo = codigo,
                            Nome = nome + '%',
                            DataMaxima = dataMaxima,
                            DataMinima = dataMinima,
                            Descricao = descricaoGenero + '%'
                        });
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Enumerable.Empty<ClienteGenero>();
            }
        }
    
        public void CadastrarCliente(Cliente cliente)
        {
            try
            {
                using (var conexao = ConexaoSql.ObterConexao())
                {
                    conexao.Execute(@"INSERT INTO [CLIENTE] (Nome, Sobrenome, GeneroId, DataNascimento, Endereco, Numero, Cep, Bairro)
                    VALUES (@Nome, @Sobrenome, @GeneroId, @DataNascimento, @Endereco, @Numero, @Cep, @Bairro)",
                    new{
                        nome = cliente.Nome,
                        sobrenome = cliente.Sobrenome,
                        generoid = cliente.GeneroId,
                        dataNascimento = cliente.DataNascimento.Date,
                        endereco = cliente.Endereco,
                        numero = cliente.Numero,
                        cep = cliente.Cep.Replace("-",string.Empty),
                        bairro = cliente.Bairro
                    });
                }
                MessageBox.Show("Cliente cadastrado com sucesso.");
            }    
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
        public void EditarCliente(Cliente cliente)
        {
            try
            {
                using (var conexao = ConexaoSql.ObterConexao())
                {
                    conexao.Execute("UPDATE [Cliente] SET Nome = @Nome, Sobrenome = @Sobrenome, GeneroId = @GeneroId," +
                        "DataNascimento = @DataNascimento, Endereco = @Endereco, Numero = @Numero, Cep = @Cep, Bairro = @Bairro WHERE Id = @Id",
                        new
                        {
                            Id = cliente.Id,
                            Nome = cliente.Nome,
                            Sobrenome = cliente.Sobrenome,
                            GeneroId = cliente.GeneroId,
                            DataNascimento = cliente.DataNascimento,
                            Endereco = cliente.Endereco,
                            Numero = cliente.Numero,
                            Cep = cliente.Cep.Replace("-", string.Empty),
                            Bairro = cliente.Bairro
                        });
                }

                MessageBox.Show("Edição realizada com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void EliminarCliente(int id)
        {
            try
            {
                using (var conexao = ConexaoSql.ObterConexao())
                {
                    conexao.Execute("UPDATE [Cliente] SET Eliminado = 1 WHERE Id = @Id", new { Id = id });
                }
                MessageBox.Show("Cliente eliminado com sucesso.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
