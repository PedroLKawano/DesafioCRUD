using Dapper;
using DesafioCRUD.Models;

namespace DesafioCRUD.Repositories
{
    public class ClienteRepository
    {
        public IEnumerable<ClienteGenero> ListarClientes(int? codigo, string? nome, int? idade, string? descricao)
        {
            try 
            {
                using (var conexao = ConexaoSql.ObterConexao())
                {
                    conexao.Open();

                    string consulta = @"SELECT c.ID, c.Nome, c.Sobrenome, g.Descricao AS DescricaoGenero, c.DataNascimento, c.Endereco, c.Numero, c.Cep, c.Bairro
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
                        //dataMinima = dataMaxima.AddYears(-1);
                        consulta += " AND c.DataNascimento > @DataMinima AND c.DataNascimento <= @DataMaxima";
                    } 
                    
                    if (!string.IsNullOrEmpty(descricao))
                        consulta += " AND g.Descricao LIKE @Descricao";

                    return conexao.Query<ClienteGenero>(consulta, new {Codigo = codigo, Nome = nome + '%', DataMaxima = dataMaxima, DataMinima = dataMinima, Descricao = descricao + '%'});
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
                    conexao.Open();
                    conexao.Execute(@"INSERT INTO [CLIENTE] (Nome, Sobrenome, GeneroId, DataNascimento, Endereco, Numero, Cep, Bairro)
                    VALUES (@Nome, @Sobrenome, @GeneroId, @DataNascimento, @Endereco, @Numero, @Cep, @Bairro)",
                    new{
                        nome = cliente.Nome,
                        sobrenome = cliente.Sobrenome,
                        generoid = cliente.GeneroId,
                        datanascimento = cliente.DataNascimento.Date,
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
    }
}
