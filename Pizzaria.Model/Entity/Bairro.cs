using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(nameof(Bairro))]
    public class Bairro
    {
        [Key]
        public int BairroID { get; set; }
        [Required(ErrorMessage ="Nome do Bairro é obrigatório")]
        [MaxLength(50,ErrorMessage = "Nome do Bairro deve conter no máximo 50 caracteres")]
        [MinLength(2,ErrorMessage ="Nome do Bairro deve conter mais que 2 caracteres")]
        public string Nome { get; set; }
    }
}