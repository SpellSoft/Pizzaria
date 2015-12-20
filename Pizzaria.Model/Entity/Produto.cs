using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pizzaria.Model.Entity
{
    public class Produto
    {
        [Key]
        [Range(type: typeof(ushort), minimum: "0", maximum: "65535",ErrorMessage = "{0} excedido, contate o administrador")]
        [DisplayName(displayName:"Produto ID")]
        public ushort ProdutoID { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(maximumLength:50,ErrorMessage = "{0} deve conter pelo menos 50 letras.")]
        [DisplayName(displayName: "Produto Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(maximumLength: 13, ErrorMessage = "{0} deve conter pelo menos 13 letras.")]
        [DisplayName(displayName: "Produto Código")]
        public string Codigo { get; set; }
        [DisplayName(displayName: "Gerenciar Estoque")]
        public bool Gerenciar { get; set; }
        [Range(type:typeof(double),minimum:"0",maximum:"1000",ErrorMessage = "{0} incorreto.")]
        [DisplayName("Preço de Compra/Custo")]
        [DataType(DataType.Currency, ErrorMessage = "{0} invalido.")]
        public double? PrecoCompra { get; set; }
        [DisplayName("Preço de Venda")]
        [DataType(DataType.Currency,ErrorMessage = "{0} invalido.")]
        [Range(typeof(double),minimum:"0", maximum: "1000", ErrorMessage = "{0} incorreto.")]        
        public double PrecoVenda { get; set; }



        [Range(type: typeof(ushort),minimum: "0",maximum: "65535", ErrorMessage = "{0} excedido, contate o administrador")]
        [DisplayName(displayName: "Produto ID")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        public ushort CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Estoque Estoque { get; set; }
    }
}
