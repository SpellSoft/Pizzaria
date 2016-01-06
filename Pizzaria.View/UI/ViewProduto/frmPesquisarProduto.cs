using Mike.Utilities.Desktop;
using Pizzaria.Controller.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
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
        private CheckBox[] GetAllCheckBox()
        {
            return new CheckBox[] { ckbCategoria, ckbCódigo, ckbNome };
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

        private void ckbNome_CheckedChanged(object sender, EventArgs e)
        {
            ChecarCkb(sender);
        }
           
        private void ckbCódigo_CheckedChanged(object sender, EventArgs e)
        {
            ChecarCkb(sender);
        }

        private void ckbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            ChecarCkb(sender);
        }

        private void ChecarCkb(object sender)
        {
            foreach (CheckBox ckb in GetAllCheckBox().Where(c => c != (sender as CheckBox)))
            {
                if (GetAllCheckBox().Where(c => c.Checked == true).Count() > 1)
                {
                    ckb.Checked = false;
                }
            }
        }
    }
}
