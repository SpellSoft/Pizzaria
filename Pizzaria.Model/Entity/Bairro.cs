using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Model.Entity
{
    public class Bairro
    {
        [Key]
        public int BairroID { get; set; }
        public string Nome { get; set; }
    }
}