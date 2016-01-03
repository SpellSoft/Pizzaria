using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(name: nameof(Categoria))]
    public class Categoria
    {
        [Key]
        [Range(type: typeof(int), minimum: "0", maximum: "60000", ErrorMessage = "Categoria ID excedido, contate o administrador")]
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "Categoria do Produto é obrigatório.")]
        [StringLength(maximumLength: 30, ErrorMessage = "Categoria do Produto deve conter pelo menos 30 letras.")]
        public string Nome { get; set; }
    }
}