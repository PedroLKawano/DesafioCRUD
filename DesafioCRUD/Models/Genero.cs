using Dapper.Contrib.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesafioCRUD.Models
{
    [Table("[Genero]")]
    public class Genero
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
    }
}
