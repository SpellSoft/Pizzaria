using Mike.Utilities.Desktop;
using Pizzaria.Controller.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Pizzaria.View.Utilities;

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
            AddInDataGridView(_produtoRepositorio.ListarPesquisa());
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
            LimparTxt();
            FocarNoTxt();
        }

        private void ckbCódigo_CheckedChanged(object sender, EventArgs e)
        {
            ChecarCkb(sender);
            LimparTxt();
            FocarNoTxt();
        }

        private void ckbCategoria_CheckedChanged(object sender, EventArgs e)
        {
            ChecarCkb(sender);
            LimparTxt();
            FocarNoTxt();
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

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CheckBox ckb = GetCheckBoxSelecionado();
            switch (ckb?.Name)
            {
                case nameof(ckbNome):
                    InsProdutoRep();
                    AddInDataGridView(_produtoRepositorio.ListarPesquisa(GetValueInTxt()));
                    break;
                case nameof(ckbCódigo):
                    InsProdutoRep();
                    AddInDataGridView(_produtoRepositorio.ListarPorCodigo(GetValueInTxt()));
                    break;
                case nameof(ckbCategoria):
                    InsProdutoRep();
                    AddInDataGridView(_produtoRepositorio.ListarPorCategoria(GetValueInTxt()));
                    break;
                default:
                    CustomMessage.MessageFullComButtonOkIconeDeInformacao("Selecione um tipo de pesquisa");
                    txtPesquisa.LimparTxtNoEventoChanged(txtPesquisa_TextChanged);
                    break;
            }
        }

        private string GetValueInTxt()
                       => txtPesquisa.Text;
        private CheckBox GetCheckBoxSelecionado()
        {
            return GetAllCheckBox().FirstOrDefault(c => c.Checked == true);
        }

        private void FocarNoTxt()
                     => this.FocoNoTxt(txtPesquisa);
        private void LimparTxt()
                     => txtPesquisa.Text = string.Empty;
        private void AddInDataGridView(object dataSource)
                       => dgvProduto.DataSource = dataSource;

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.IntegerAndLetter(e);
            ValidatorField.AllowOneSpaceTogether(e, sender);
        }
    }


}
