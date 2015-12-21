using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(name:nameof(Produto))]
    public class Produto
    {
       
        [Key]
        [Range(type: typeof(int), minimum: "0", maximum: "10000",ErrorMessage = "{0} excedido, contate o administrador")]
        [DisplayName(displayName:"Produto ID")]
        public int ProdutoID { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(maximumLength:50,ErrorMessage = "{0} deve conter pelo menos 50 letras.")]
        [DisplayName(displayName: "Produto Nome")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "{0} é obrigatório.")]
        [StringLength(maximumLength: 13, ErrorMessage = "{0} deve conter pelo menos 13 letras.")]
        [DisplayName(displayName: "Produto Código")]
        public string Codigo { get; set; }      

        private double? precoCompra;
        [Range(type: typeof(double), minimum: "0", maximum: "1000", ErrorMessage = "{0} incorreto.")]
        [DisplayName("Preço de Compra/Custo")]
        [DataType(DataType.Currency, ErrorMessage = "{0} invalido.")]
        public double? PrecoCompra
        {
            get { return precoCompra; }
            set { precoCompra = value; }
        } 
        private double precoVenda;
        [DisplayName("Preço de Venda")]
        [DataType(DataType.Currency, ErrorMessage = "{0} invalido.")]
        [Range(typeof(double), minimum: "0", maximum: "1000", ErrorMessage = "{0} incorreto.")]
        public double PrecoVenda
        {
            get { return precoVenda; }
            set
            {
                if (precoCompra > value)
                {
                    throw new Exception("Valor de venda não pode ser menor que o valor de compra.");
                }
                else
                {
                    precoVenda = value;
                }
              
            }
        }
        
        [Range(type: typeof(int),minimum: "0",maximum: "10000", ErrorMessage = "{0} excedido, contate o administrador")]
        [DisplayName(displayName: "Categoria ID")]
        [Required(ErrorMessage = "{0} é obrigatório.")]
        public int CategoriaID { get; set; }
        public virtual Categoria Categoria { get; set; }
        public virtual Estoque Estoque { get; set; }
        [StringLength(maximumLength: 100, ErrorMessage = "{0} deve conter pelo menos 100 letras.")]
        [DisplayName(displayName: "Produto Descrição")]
        public string Descricao { get; set; }
        public int ComplementoID { get; set; }
        public virtual List<Complemento> Complemento { get; set; }



    }
}
