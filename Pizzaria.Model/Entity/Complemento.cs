using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    public class Complemento
    {
        [ForeignKey(nameof(Produto))]
        [Range(type: typeof(int), minimum: "0", maximum: "60000", ErrorMessage = "{0} excedido, contate o administrador")]
        [DisplayName(displayName: "Produto ID")]
        public int ProdutoID { get; set; }
        //[Range(type: typeof(int), minimum: "0", maximum: "60000", ErrorMessage = "{0} excedido, contate o administrador")]
        //[DisplayName(displayName: "Sabor ID")]
        //public int SaborID { get; set; }
        public List<Sabor> Sabor { get; set; }
        [StringLength(maximumLength: 100, ErrorMessage = "{0} deve conter pelo menos 100 letras.")]
        [DisplayName(displayName: "Produto Descrição")]       
        public string Descricao { get; set; }
        [DisplayName("Preço")]
        [DataType(DataType.Currency, ErrorMessage = "{0} invalido.")]
        [Range(typeof(double), minimum: "0", maximum: "1000", ErrorMessage = "{0} incorreto.")]
        public double Preco { get; set; }
    }
}