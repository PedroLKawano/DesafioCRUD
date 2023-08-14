using Dapper;
using DesafioCRUD.Models;

namespace DesafioCRUD.Repositories
{
    public class ClienteRepository
    {
        public IEnumerable<Cliente> ListarClientes()
        {
            try 
            {
                using (var conexao = ConexaoSql.ObterConexao())
                {
                    conexao.Open();
                    return conexao.Query<Cliente>("SELECT Nome, Sobrenome, GeneroId, DataNascimento, Endereco, Numero, Cep, Bairro FROM [Cliente]");                    
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return Enumerable.Empty<Cliente>();
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
