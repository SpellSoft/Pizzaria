using Mike.Utilities.Desktop;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(name: nameof(Produto))]
    public class Produto
    {

        [Key]
        [Range(type: typeof(int), minimum: "0", maximum: "10000", ErrorMessage = "ID do Produto excedido, contate o administrador")]
        [DisplayName(displayName: "ID do Produto")]
        public int ProdutoID { get; set; }

        public int TipoProduto { get; set; }

        [Required(ErrorMessage = "Nome do Produto é obrigatório.")]
        [StringLength(maximumLength: 50, ErrorMessage = "Nome do Produto deve conter pelo menos 50 letras.")]
        [DisplayName(displayName: "Nome do Produto")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Código do Produto é obrigatório.")]
        [StringLength(maximumLength: 13, ErrorMessage = "Código do Produto deve conter pelo menos 13 letras.")]
        [DisplayName(displayName: "Código do Produto")]
        public string Codigo { get; set; }

        private decimal? precoCompra;
        [Range(type: typeof(decimal), minimum: "0", maximum: "1000", ErrorMessage = "Preço de Compra incorreto.")]
        [DataType(DataType.Currency, ErrorMessage = "Preço de Compra inválido.")]
        public decimal? PrecoCompra
        {
            get { return precoCompra; }
            set { precoCompra = value; }
        }
        private decimal precoVenda;
        [Required(ErrorMessage = "Preço de Venda é obrigatório.")]
        [DataType(DataType.Currency, ErrorMessage = "Preço de Venda inválido.")]
        [Range(typeof(decimal), minimum: "0,01", maximum: "1000", ErrorMessage = "Preço de Venda deve ser maior que 0.0 R$ e menor que 1.000 R$.")]
        public decimal PrecoVenda
        {
            get { return precoVenda; }
            set
            {
                if (precoCompra > value)
                {
                    throw new CustomException("Valor de venda não pode ser menor que o valor de compra.");
                }
                else
                {
                    precoVenda = value;
                }

            }
        }
        [Range(type: typeof(int), minimum: "0", maximum: "10000", ErrorMessage = "Categoria excedido, contate o administrador")]      
        [Required(ErrorMessage = "Categoria é obrigatório.")]
        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Estoque Estoque { get; set; }
        [StringLength(maximumLength: 100, ErrorMessage = "Descrição do Produto deve conter pelo menos 100 letras.")]
     
        public string Descricao { get; set; }
        public virtual List<Complemento> Complemento { get; set; }
        [ForeignKey(nameof(Sabor))]
        public int? SaborID { get; set; }
        [ForeignKey(nameof(Borda))]
        public int? BordaID { get; set; }
        public virtual Borda Borda { get; set; }
        public virtual Sabor Sabor { get; set; }



    }
}
