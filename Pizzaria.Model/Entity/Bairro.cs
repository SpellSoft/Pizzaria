using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(nameof(Bairro))]
    public class Bairro
    {
        [Key]
        public int BairroID { get; set; }
        public string Nome { get; set; }
    }
}