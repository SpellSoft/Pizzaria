using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(name: nameof(Complemento))]
    public class Complemento
    {
        [Key]
        [Range(type: typeof(int), minimum: "0", maximum: "60000", ErrorMessage = "Complemento ID excedido, contate o administrador")]

        public int ComplementoID { get; set; }
        [Range(type: typeof(int), minimum: "0", maximum: "60000", ErrorMessage = "Sabor ID excedido, contate o administrador")]

        public int? SaborID { get; set; }
        public Sabor Sabor { get; set; }
        [StringLength(maximumLength: 100, ErrorMessage = "Descrição de Complemento deve conter pelo menos 100 letras.")]

        public string Descricao { get; set; }
        [Required(ErrorMessage = "Preço do Complemento é obrigatório.")]
        [DataType(DataType.Currency, ErrorMessage = "Preço do Complemento inváido.")]
        [Range(typeof(decimal), minimum: "0,01", maximum: "50", ErrorMessage = "Preço do Complemento deve ser maio que 0,0 R$ e menor que 50,0 R$")]
        public decimal Preco { get; set; }
        public virtual Produto Produto { get; set; }
    }
}