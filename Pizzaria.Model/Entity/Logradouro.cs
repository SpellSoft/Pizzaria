using System.ComponentModel.DataAnnotations;

namespace Pizzaria.Model.Entity
{
    
    public class Logradouro
    {
        [Key]
        public int LogradouroID { get; set; }
        public string Nome { get; set; }
       
    }
}
