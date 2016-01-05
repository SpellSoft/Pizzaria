using Mike.Utilities.Desktop;
using Pizzaria.Controller.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Pizzaria.View.UI.ViewProduto
{
    public partial class frmPesquisarProduto : Form
    {
        private ProdutoRepositorio _produtoRepositorio;
        private void InsProdutoRep()
        {
            _produtoRepositorio = new ProdutoRepositorio();
        }
        public frmPesquisarProduto()
        {
            InitializeComponent();
        }

        private void frmPesquisarProduto_Load(object sender, EventArgs e)
        {
            InsProdutoRep();
            CarregarDataGridView();
            EsconderColunaDoDataGridView();


        }

        private void EsconderColunaDoDataGridView()
        {
            dgvProduto.EsconderColuna("ProdutoID");
        }
        private void AjustarTamanhoDoDataGridView()
        {
            dgvProduto.AjustartamanhoDoDataGridView(new List<TamanhoGrid>
            {

                 new TamanhoGrid { ColunaNome="Nome", Tamanho = 180 },
                 new TamanhoGrid { ColunaNome = "Código", Tamanho = 120 },
                 new TamanhoGrid { ColunaNome="Categoria", Tamanho = 120 },
                   new TamanhoGrid { ColunaNome="PrecoVenda", Tamanho = 120 },
            });

        }

        private void CarregarDataGridView()
        {
            dgvProduto.DataSource = _produtoRepositorio.ListarPesquisa();
            PadronizarDataGridView();
            AjustarTamanhoDoDataGridView();
        }

        private void PadronizarDataGridView()
        {
            dgvProduto.PadronizarGrid();
        }

        private void dgvProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Format = "C2";
        }
    }
}
