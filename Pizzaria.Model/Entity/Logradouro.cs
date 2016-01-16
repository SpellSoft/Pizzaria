using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{

    [Table(nameof(Logradouro))]
    public class Logradouro
    {
        [Key]
        public int LogradouroID { get; set; }
        [Required(ErrorMessage = "Nome do Logradouro é obrigatório.")]
        [StringLength(50,MinimumLength =2,ErrorMessage ="Nome do Logradouro deve ter entre 2 e 50 caracteres.")]
        public string Nome { get; set; }
       
    }
}
