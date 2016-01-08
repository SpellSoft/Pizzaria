using System;
using System.Windows.Forms;
using Pizzaria.View.Utilities;
using Pizzaria.Controller.Repository;
using Mike.Utilities.Desktop;
using System.Collections.Generic;
using Pizzaria.Model.ModelView;

namespace Pizzaria.View.UI.ViewProduto
{
    public partial class frmGerenciarProduto : Form
    {
        private ProdutoRepositorio _produtoRepositorio;
        

        private object ProdutoDgv
        {
            set { dgvPesquisarProduto.DataSource = value; }
        }
        private ProdutoRepositorio InsProdutoRep()
                => _produtoRepositorio = new ProdutoRepositorio();
        public frmGerenciarProduto()
        {
            InitializeComponent();
        }

        private void frmGerenciarProduto_Load(object sender, EventArgs e)
        {
            Array.ForEach(GetAllButton(), c => c.Padronizar());
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            ProdutoDgv = InsProdutoRep().ListarPesquisa();
            PagrinizarDgv();
            EsconderColunaDgv();
            AjustarTamanhoDoDataGridView();
        }
        private void AjustarTamanhoDoDataGridView()
        {
            dgvPesquisarProduto.AjustartamanhoDoDataGridView(new List<TamanhoGrid>
            {

               new TamanhoGrid { ColunaNome=nameof(ProdutoPesquisaViewModel.Nome), Tamanho = 215 },
                 new TamanhoGrid { ColunaNome =nameof(ProdutoPesquisaViewModel.Código), Tamanho = 125 },
                 new TamanhoGrid { ColunaNome=nameof(ProdutoPesquisaViewModel.Categoria), Tamanho = 165 },
                   new TamanhoGrid { ColunaNome=nameof(ProdutoPesquisaViewModel.PrecoVenda), Tamanho = 85 }
            });

        }
        private void EsconderColunaDgv()
        {
            dgvPesquisarProduto.EsconderColuna(nameof(ProdutoPesquisaViewModel.ProdutoID));
        }

        private void PagrinizarDgv()
        {
            dgvPesquisarProduto.PadronizarGrid();
        }

        private Button[] GetAllButton()
        {
            return new Button[] {btnDeletar,btnEditar,btnNovo,btnSair };
        }

        private void dgvPesquisarProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Format = "C2";
        }
    }
}
