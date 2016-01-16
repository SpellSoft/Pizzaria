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
                    CadastrarCliente();
                    break;
                case EnumTipoOperacao.Editar:
                    break;
                case EnumTipoOperacao.Deletar:
                    break;
                case EnumTipoOperacao.Sair:
                    break;
                case EnumTipoOperacao.Detalhes:
                    break;
             
            }

        }

        private void PadronizarButton()
        {
            btnCadastrarCidade.Padronizar();
        }

        private void CadastrarCliente()
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
        }

        private void txtNomeCidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            ValidatorField.IntegerAndLetter(e);
        }
    }
}
