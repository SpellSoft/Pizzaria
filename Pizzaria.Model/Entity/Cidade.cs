using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(nameof(Cidade))]
    public class Cidade
    {
        [Key]
        public int CidadeID { get; set; }
        public string Nome { get; set; }
    }
}