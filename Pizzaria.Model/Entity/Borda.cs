using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model.Entity
{
    [Table(nameof(Borda))]
    public class Borda
    {
        [Key]
        [Range(type: typeof(int), minimum: "0", maximum: "60000", ErrorMessage = "{0} excedido, contate o administrador")]
        [DisplayName(displayName: "Borda ID")]
        public int BordaID { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(maximumLength: 30, ErrorMessage = "{0} deve conter pelo menos 30 letras.")]
        [DisplayName(displayName: "Borda Nome")]
        public string Nome { get; set; }
        [Range(type: typeof(double), minimum: "0", maximum: "50", ErrorMessage = "{0} incorreto.")]
        [DisplayName("Preço de venda")]
        [DataType(DataType.Currency, ErrorMessage = "{0} invalido.")]
        public double Preco { get; set; }
        [StringLength(maximumLength: 50, ErrorMessage = "{0} deve conter pelo menos 50 letras.")]
        [DisplayName(displayName: "Borda Descrição")]
        public string Descricao { get; set; }
     

    }
}
