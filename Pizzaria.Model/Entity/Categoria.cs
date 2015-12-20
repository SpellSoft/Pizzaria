using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(name:nameof(Categoria))]
    public class Categoria
    {
        [Key]
        [Range(type: typeof(int), minimum: "0", maximum: "60000", ErrorMessage = "{0} excedido, contate o administrador")]
        [DisplayName(displayName: "Categoria ID")]
        public int CategoriaID { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(maximumLength: 30, ErrorMessage = "{0} deve conter pelo menos 30 letras.")]
        [DisplayName(displayName: "Categoria Nome")]
        public string Nome { get; set; }
    }
}