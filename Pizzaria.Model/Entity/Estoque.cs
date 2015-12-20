using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pizzaria.Model.Entity
{
    public class Estoque
    {
        [Key]
        [ForeignKey(nameof(Produto))]
        public ushort ProdutoID { get; set; }

    }
}