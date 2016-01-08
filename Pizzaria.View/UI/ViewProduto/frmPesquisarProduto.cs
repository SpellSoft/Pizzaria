using Mike.Utilities.Desktop;
using Pizzaria.Controller.Repository;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using Pizzaria.View.Utilities;
using Pizzaria.Model.ModelView;

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
            PadronizarDataGridView();
            EsconderColunaDoDataGridView();
            AjustarTamanhoDoDataGridView();

        }
        private CheckBox[] GetAllCheckBox()
        {
            return new CheckBox[] { ckbCategoria, ckbCódigo, ckbNome };
        }
        private void EsconderColunaDoDataGridView()
        {
            dgvProduto.EsconderColuna(nameof(ProdutoPesquisaViewModel.ProdutoID));
        }
        private void AjustarTamanhoDoDataGridView()
        {
            dgvProduto.AjustartamanhoDoDataGridView(new List<TamanhoGrid>
            {
                 new TamanhoGrid { ColunaNome=nameof(ProdutoPesquisaViewModel.Nome), Tamanho = 215 },
                 new TamanhoGrid { ColunaNome =nameof(ProdutoPesquisaViewModel.Código), Tamanho = 125 },
                 new TamanhoGrid { ColunaNome=nameof(ProdutoPesquisaViewModel.Categoria), Tamanho = 165 },
                   new TamanhoGrid { ColunaNome=nameof(ProdutoPesquisaViewModel.PrecoVenda), Tamanho = 85 }
            });

        }
        private void CarregarDataGridView()
        {
            AddInDataGridView(_produtoRepositorio.ListarPesquisa());

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
            InsProdutoRep();
            if (_produtoRepositorio.GetQuantidade() > 0)
            {
                switch (ckb?.Name)
                {
                    case nameof(ckbNome):

                        AddInDataGridView(_produtoRepositorio.ListarPesquisa(GetValueInTxt()));
                        break;
                    case nameof(ckbCódigo):

                        AddInDataGridView(_produtoRepositorio.ListarPorCodigo(GetValueInTxt()));
                        break;
                    case nameof(ckbCategoria):

                        AddInDataGridView(_produtoRepositorio.ListarPorCategoria(GetValueInTxt()));
                        break;
                    default:
                        CustomMessage.MessageFullComButtonOkIconeDeInformacao("Selecione um tipo de pesquisa");
                        txtPesquisa.LimparTxtNoEventoChanged(txtPesquisa_TextChanged);
                        break;
                }
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
