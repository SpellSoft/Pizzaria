using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(name: nameof(Sabor))]
    public class Sabor
    {
        [Key]
        [Range(type: typeof(int), minimum: "0", maximum: "60000", ErrorMessage = "Sabor ID excedido, contate o administrador")]
        public int SaborID { get; set; }
        [Required(ErrorMessage = "Nome do Sabor é obrigatório.")]
        [StringLength(maximumLength: 50, ErrorMessage = "Nome do Sabor deve conter pelo menos 50 letras.")]
        public string Nome { get; set; }

    }
}