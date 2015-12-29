using Mike.Utilities.Desktop;
using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    [Table(name: nameof(Estoque))]
    public class Estoque
    {
        [Key]
        [ForeignKey(nameof(Produto))]
        [Range(0, maximum: int.MaxValue, ErrorMessage = "{0} invalido.")]
        public int ProdutoID { get; set; }
        [DisplayName(displayName: "Gerenciar Estoque")]
        public bool Gerenciar { get; set; }
        [Range(0, maximum: int.MaxValue, ErrorMessage = "{0} invalido.")]
        public int Quantidade { get; set; }
        [DisplayName(displayName: "Quantidade mínima")]
        [Range(0, maximum: int.MaxValue, ErrorMessage = "{0} invalido.")]
        public int QuantidadeMinima { get; set; }

        private int quantidadeMaxima;
        [DisplayName(displayName: "Quantidade máxima.")]
        [Range(0, maximum: int.MaxValue, ErrorMessage = "{0} invalido.")]
        public int QuantidadeMaxima
        {
            get { return quantidadeMaxima; }
            set
            {
                if (QuantidadeMinima > value)
                {
                    throw new CustomException("A quantidade máxima não pode ser menor que a quantidade mínima.");
                }
                else
                {
                    quantidadeMaxima = value;
                }
               
            }
        }

        public virtual Produto Produto { get; set; }
    }
}