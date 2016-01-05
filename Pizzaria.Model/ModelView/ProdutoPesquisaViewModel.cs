using System.ComponentModel;

namespace Pizzaria.Model.ModelView
{
    public class ProdutoPesquisaViewModel
    {
        [DisplayName("Produto ID")]
        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public string Código { get; set; }
        public string Categoria { get; set; }        
        [DisplayName("Preço de Venda")]
        public decimal PrecoVenda { get; set; }
    }
}
