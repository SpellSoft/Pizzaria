using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(name:nameof(Sabor))]
    public class Sabor
    {
        [Key]
        [Range(type: typeof(int), minimum: "0", maximum: "60000", ErrorMessage = "{0} excedido, contate o administrador")]
        [DisplayName(displayName: "Sabor ID")]
        public int SaborID { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(maximumLength: 50, ErrorMessage = "{0} deve conter pelo menos 50 letras.")]
        [DisplayName(displayName: "Sabor Nome")]
        public string Nome { get; set; }
    }
}