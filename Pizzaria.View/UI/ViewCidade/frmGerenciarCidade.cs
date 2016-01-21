using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using Pizzaria.View.Utilities;
using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.Enumerador;

namespace Pizzaria.View.UI.ViewCidade
{
    public partial class frmGerenciarCidade : Form
    {

        private CidadeRepositorio _cidadeRepositorio;
        private Cidade _cidade;
        private EnumTipoOperacao _tipoOperacao;
        private CidadeRepositorio InsCidadeRep()
        {
            return _cidadeRepositorio = new CidadeRepositorio();
        }
        public frmGerenciarCidade(Cidade cidade,EnumTipoOperacao tipoOperacao)
        {
            this._cidade = cidade;
            this._tipoOperacao = tipoOperacao;
            InitializeComponent();
        }

        private void frmGerenciarCidade_Load(object sender, EventArgs e)
        {
          
          
            CarregarCidade();            
            PadronizarButton();
        }

        private void CarregarCidade()
        {
            InsCidadeRep();
            dgvCidade.DataSource = _cidadeRepositorio.Listar();
            PadronizarGrid();
            EsconderColuna();
        }

        private void EsconderColuna()
        {
            dgvCidade.EsconderColuna(nameof(Cidade.CidadeID));
        }

        private void PadronizarGrid()
        {
            dgvCidade.PadronizarGrid();

        }

        private void PadronizarButton()
        {
            Array.ForEach(GetAllButton(), c => c.Padronizar());
        }

        private Button[] GetAllButton()
                => new Button[] { btnSair, btnNovo, btnEditar, btnDeletar };

        private void btnSair_Click(object sender, EventArgs e)
        {
            FecharForm();
        }

        private void FecharForm()
        {
            this.Close();
        }

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
                    FecharForm();
                    break;
                case Keys.Up:
                    MoveToUpDgv();
                    break;
                case Keys.Down:
                    MoveToDownDgv();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MoveToDownDgv()
        {
            dgvCidade.MoveToDown();
        }

        private void MoveToUpDgv()
        {
            dgvCidade.MoveToUp();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Cidade cidade;
            if ((cidade = _cidadeRepositorio.GetPeloID(GetLinhaSelecionada())) != null)
            {
                if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCidade(cidade, EnumTipoOperacao.Editar)) == DialogResult.Yes)
                {
                    CustomMessage
                        .MessageFullComButtonOkIconeDeInformacao("Cidade editada com sucesso!");
                    CarregarCidade();
                }
            }
        }
        private int GetLinhaSelecionada()
        {
            if (ExisteCidadeCadastrada())
            {
                return (int)dgvCidade.SelectedRows[0].Cells[0].Value;
            }
            return 0;
        }

        private bool ExisteCidadeCadastrada()
        {
            return _cidadeRepositorio.GetQuantidade() > 0;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            Cidade cidade;
            if ((cidade = _cidadeRepositorio.GetPeloID(GetLinhaSelecionada())) != null)
            {
                if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCidade(cidade, EnumTipoOperacao.Deletar)) == DialogResult.Yes)
                {
                    CustomMessage
                       .MessageFullComButtonOkIconeDeInformacao("Cidade deletada com sucesso!");
                    CarregarCidade();
                }
            }
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCidade(new Cidade(), EnumTipoOperacao.Novo)) == DialogResult.Yes)
            {
                CustomMessage
                     .MessageFullComButtonOkIconeDeInformacao("Cidade cadastrado com sucesso!");
                CarregarCidade();
            }
        }

        private void txtPesquisa_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            ValidatorField.IntegerAndLetter(e);
        }

        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            if (ExisteCidadeCadastrada())
            {
                dgvCidade.DataSource = _cidadeRepositorio.PesquisarPorNome(GetTextDoTxt());
            }
        }

        private string GetTextDoTxt()
        {
            return txtPesquisa.Text.ToLower().Trim();
        }
    }
}
