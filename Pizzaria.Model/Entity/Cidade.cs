using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Model.Entity
{
    public class Cidade
    {
        [Key]
        public int CidadeID { get; set; }
        public string Nome { get; set; }
    }
}