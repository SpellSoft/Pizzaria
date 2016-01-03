using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(nameof(Borda))]
    public class Borda
    {
        [Key]
        [Range(type: typeof(int), minimum: "0", maximum: "60000", ErrorMessage = "Borda ID excedido, contate o administrador")]
        public int BordaID { get; set; }
        [StringLength(maximumLength: 30, ErrorMessage = "Nome da Borda deve conter pelo menos 30 letras.")]
        [Required(ErrorMessage = "Nome da Borda é obrigatório")]
        public string Nome { get; set; }
        [Range(type: typeof(decimal), minimum: "0,01", maximum: "50", ErrorMessage = "Preço da Borda deve ser maior que 0.0 R$ e menor que 50.00 R$.")]
        [DataType(DataType.Currency, ErrorMessage = "Preço da Borda inválido.")]
        [Required(ErrorMessage = "Preço da Borda é obrigatório")]
        public decimal Preco { get; set; }
        [StringLength(maximumLength: 50, ErrorMessage = "Descrição da borda deve conter no máximo 50 letras.")]
        public string Descricao { get; set; }


    }
}
