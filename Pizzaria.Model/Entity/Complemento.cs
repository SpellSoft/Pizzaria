using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(name:nameof(Complemento))]
    public class Complemento
    {
        [Key]
        [Range(type: typeof(int), minimum: "0", maximum: "60000", ErrorMessage = "{0} excedido, contate o administrador")]
        [DisplayName(displayName: "Complemento ID")]        
        public int ComplementoID { get; set; }
        [Range(type: typeof(int), minimum: "0", maximum: "60000", ErrorMessage = "{0} excedido, contate o administrador")]
        [DisplayName(displayName: "Sabor ID")]
        public int? SaborID { get; set; }
        public Sabor Sabor { get; set; }
        [StringLength(maximumLength: 100, ErrorMessage = "{0} deve conter pelo menos 100 letras.")]
        [DisplayName(displayName: "Complemento Descrição")]       
        public string Descricao { get; set; }
        [DisplayName("Preço")]
        [DataType(DataType.Currency, ErrorMessage = "{0} invalido.")]
        [Range(typeof(double), minimum: "0", maximum: "1000", ErrorMessage = "{0} incorreto.")]
        public double Preco { get; set; }
        public virtual Produto Produto { get; set; }
    }
}