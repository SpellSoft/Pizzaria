using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using Pizzaria.View.Enumerador;
using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.Utilities;
namespace Pizzaria.View.UI.ViewCidade
{
    public partial class frmCadastrarCidade : Form
    {
        private CidadeRepositorio _cidadeRepositorio;
        private CidadeRepositorio InsCidadeRep()
                => _cidadeRepositorio = new CidadeRepositorio();
        private Cidade _cidade;
        private EnumTipoOperacao _enumTipoOperacao;
        public frmCadastrarCidade(Cidade cidade, EnumTipoOperacao tipoOPeracao)
        {
            this._cidade = cidade;
            this._enumTipoOperacao = tipoOPeracao;
            InitializeComponent();
        }

        private void btnCadastrarCidade_Click(object sender, EventArgs e)
        {
            switch (_enumTipoOperacao)
            {
                case EnumTipoOperacao.Novo:
                    CadastrarCidade();
                    break;
                case EnumTipoOperacao.Editar:
                    EditarCidade();
                    break;
                case EnumTipoOperacao.Deletar:
                    DeletarCliente();
                    break;
                case EnumTipoOperacao.Sair:
                   
                    break;
                case EnumTipoOperacao.Detalhes:
                  
                    break;

            }

        }

        private void DeletarCliente()
        {
            Cidade cidade = PupulaCidade();
            if (_cidadeRepositorio.Deletar(cidade.CidadeID))
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
                MessageBox.Show("houve um errro");

        }

        private void EditarCidade()
        {
            Cidade cidade = PupulaCidade();
            var txt = ValidaCampos.ValidarTxt(cidade, GetAllTxt());
            if (txt == null)
            {
                if (_cidadeRepositorio.Editar(cidade))
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else
                    MessageBox.Show("houve um errro");
            }
            else
                FocarNoTxt(txt: txtNomeCidade);
        }

        private void MudarIconeDoButton(EnumTipoOperacao tipo, string nameIco)
        {
            GerenciarControl.MudarIConeDoButton(btn: btnCadastrarCidade, operecao: tipo, iconeName: nameIco);
        }

        private void MudarTextoDoButton(string texto)
        {
            btnCadastrarCidade.Text = texto;
        }

        private void DesabilitarOuHabilitarTextBox(TextBox txt, bool mostrar = false)
        {
            GerenciarControl.DesabilitarOuHabilitarTextBox(txt, mostrar);
        }

        private void PopularTextBox()
        {
            txtNomeCidade.Text = _cidade.Nome;
        }

        private void PadronizarButton()
        {
            btnCadastrarCidade.Padronizar();
        }

        private void CadastrarCidade()
        {
            Cidade cidade = PupulaCidade();
            var txt = ValidaCampos.ValidarTxt(cidade, GetAllTxt());
            if (txt == null)
            {
                if (_cidadeRepositorio.Salvar(cidade))
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else
                    MessageBox.Show("houve um errro");
            }
            else
                FocarNoTxt(txt: txtNomeCidade);
        }

        private Cidade PupulaCidade()
        {
            return new Cidade
            {
                CidadeID = _cidade.CidadeID,
                Nome = txtNomeCidade.Text.Trim().UpperCaseOnlyFirst()
            };
        }

        private void FocarNoTxt(TextBox txt)
                => this.FocoNoTxt(txt);
        private TextBox[] GetAllTxt()
        {
            return new TextBox[] { txtNomeCidade };
        }

        private void frmCadastrarCidade_Load(object sender, EventArgs e)
        {
            InsCidadeRep();
            switch (_enumTipoOperacao)
            {
                case EnumTipoOperacao.Novo:
                    FocarNoTxt(txtNomeCidade);
                    break;
                case EnumTipoOperacao.Editar:
                    PopularTextBox();
                    MudarTextoDoButton(EnumTipoOperacao.Editar.ToString());
                    MudarIconeDoButton(EnumTipoOperacao.Editar, EnumTipoIconCrud.Editar.SetIcon(EnumExtensao.ico));
                    PadronizarButton();
                    FocarNoTxt(txtNomeCidade);
                    break;
                case EnumTipoOperacao.Deletar:
                    PopularTextBox();
                    DesabilitarOuHabilitarTextBox(txt: txtNomeCidade);
                    MudarTextoDoButton(EnumTipoOperacao.Deletar.ToString());
                    MudarIconeDoButton(EnumTipoOperacao.Deletar, EnumTipoIconCrud.Deletar.SetIcon(EnumExtensao.ico));
                    PadronizarButton();

                    FocarNoTxt(txtNomeCidade);
                    break;
                case EnumTipoOperacao.Sair:
                    DesabilitarOuHabilitarTextBox(txt: txtNomeCidade);
                    PopularTextBox();
                    MudarTextoDoButton(EnumTipoOperacao.Sair.ToString());
                    MudarIconeDoButton(EnumTipoOperacao.Sair, EnumTipoIconCrud.Sair.SetIcon(EnumExtensao.ico));
                    PadronizarButton();
                    FocarNoTxt(txtNomeCidade);
                    break;
                case EnumTipoOperacao.Detalhes:
                    DesabilitarOuHabilitarTextBox(txt: txtNomeCidade);
                    PopularTextBox();
                    MudarTextoDoButton(EnumTipoOperacao.Detalhes.ToString());
                    MudarIconeDoButton(EnumTipoOperacao.Detalhes, EnumTipoIconCrud.Sair.SetIcon(EnumExtensao.ico));
                    PadronizarButton();
                    FocarNoTxt(txtNomeCidade);
                    break;

            }
          
        }

      

        private void txtNomeCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            ValidatorField.IntegerAndLetter(e);
        }
    }
}
