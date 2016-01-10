using System;
using System.Windows.Forms;
using Pizzaria.View.Utilities;
using Pizzaria.Controller.Repository;
using Mike.Utilities.Desktop;
using System.Collections.Generic;
using Pizzaria.Model.ModelView;
using Pizzaria.View.Enumerador;
using Pizzaria.Model.Entity;

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

            try
            {
                Array.ForEach(GetAllButton(), c => c.Padronizar());
                CarregarGrid();
                FocarNotxt();
                TirarFocoDoDgv();

            }
            catch (CustomException error)
            {
                CustomMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                CustomMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }

        }

        private void TirarFocoDoDgv()
        {
            if (dgvPesquisarProduto.Rows.Count > 0)
            {
                dgvPesquisarProduto.LimparSelecao();
            }

        }
        private void FocarNotxt()
        {
            this.FocoNoTxt(txtNome);
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
            return new Button[] { btnDeletar, btnEditar, btnNovo, btnSair };
        }

        private void dgvPesquisarProduto_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            e.CellStyle.Format = "C2";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarProduto(EnumTipoOperacao.Novo, null)) == DialogResult.Yes)
            {
                CarregarGrid();
            }

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.IntegerAndLetter(e: e);
            ValidatorField.AllowOneSpaceTogether(e, sender);
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            InsProdutoRep();
            if (SeExisteProduto())
            {
                ProdutoDgv = _produtoRepositorio.ListarPesquisa(txtNome.Text);
                dgvPesquisarProduto.ClearSelection();
            }
        }

        private bool SeExisteProduto()
                     => _produtoRepositorio.GetQuantidade() > 0;

        private void btnSair_Click(object sender, EventArgs e)
        {
            FecharForm();
        }

        private void FecharForm()
                => this.Close();


        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.F1:

                    break;
                case Keys.F2:

                    break;
                case Keys.F3:

                    break;
                case Keys.F4:

                    break;
                case Keys.F5:

                    break;
                case Keys.F6:

                    break;
                case Keys.F7:

                    break;
                case Keys.F8:

                    break;
                case Keys.F9:
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:

                    break;
                case Keys.Escape:

                    break;
                case Keys.Enter:

                    break;
                case Keys.Up:
                    MoverDgvParaCima();
                    break;
                case Keys.Down:
                    MoverDgvParaBaixo();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private Produto GetProdutoSelecionadoNoDgv()
        {
            InsProdutoRep();
            return _produtoRepositorio.GetPeloCodigo(GetCodidoSelecionado());
        }

        private void MoverDgvParaBaixo()
        {
            dgvPesquisarProduto.MoveToDown();
        }
        private string GetCodidoSelecionado()
        {
            return dgvPesquisarProduto.GetLineSelectValue(nameof(ProdutoPesquisaViewModel.Código));
        }
        private void MoverDgvParaCima()
        {
            dgvPesquisarProduto.MoveToUp();
        }

        private bool SeDgvEstaValido()
                    => dgvPesquisarProduto.Rows.Count > 0 && InsProdutoRep().GetQuantidade() > 0;

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Produto produto = GetProdutoSelecionadoNoDgv();
            if (produto != null)
            {
                if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarProduto(EnumTipoOperacao.Deletar, produto)) == DialogResult.Yes)
                {
                    CustomMessage.MessageFullComButtonOkIconeDeInformacao($"Produto {produto.Nome} deletado com sucesso.");
                    CarregarGrid();
                }
            }

        }

        private Produto GetProdutoAtualNoDgv()
        {
            InsProdutoRep();
            Produto produto = null;
            if (DgvPossuiResgistro())
            {
                string codigo = dgvPesquisarProduto.CurrentRow.Cells[nameof(ProdutoPesquisaViewModel.Código)].Value.ToString();
                produto = _produtoRepositorio.GetPeloCodigo(codigo);
            }
            return produto;
        }

        private bool DgvPossuiResgistro()
        {
            return dgvPesquisarProduto.Rows.Count > 0;
        }

        private void dgvPesquisarProduto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                Produto produto = GetProdutoAtualNoDgv();
                if (produto != null)
                {
                    OpenMdiForm.OpenForWithShowDialog(new frmCadastrarProduto(EnumTipoOperacao.Detalhes, produto));
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Produto produto = GetProdutoAtualNoDgv();
            if (produto != null)
            {
                if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarProduto(EnumTipoOperacao.Editar, produto)) == DialogResult.Yes)
                {
                    CarregarGrid();
                }
            }
        }
    }
}
