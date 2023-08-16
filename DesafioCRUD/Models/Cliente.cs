using Dapper.Contrib.Extensions;

namespace DesafioCRUD.Models
{
    [Table("[Cliente]")]
    public class Cliente
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public int GeneroId { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Endereco { get; set; }
        public string Numero { get; set; }
        public string Cep { get; set; }
        public string Bairro { get; set; }
        public bool Eliminado { get; set; }
    }
}
