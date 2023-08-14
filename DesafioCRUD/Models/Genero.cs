using Dapper.Contrib.Extensions;

namespace DesafioCRUD.Models
{
    [Table("[Genero]")]
    public class Genero
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
