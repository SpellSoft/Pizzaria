using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{

    [Table(nameof(Logradouro))]
    public class Logradouro
    {
        [Key]
        public int LogradouroID { get; set; }
        public string Nome { get; set; }
       
    }
}
