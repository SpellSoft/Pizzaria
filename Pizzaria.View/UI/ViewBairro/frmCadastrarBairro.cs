using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using Pizzaria.View.Enumerador;
using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.Utilities;

namespace Pizzaria.View.UI.ViewBairro
{
    public partial class frmCadastrarBairro : Form
    {
        private BairroRepositorio _bairroRepositorio;

        private BairroRepositorio InsBairroRep()
                => _bairroRepositorio = new BairroRepositorio();
        private Bairro _bairro;
        private EnumTipoOperacao _enumTipoOperacao;
        public frmCadastrarBairro(Bairro bairro,EnumTipoOperacao tipoOperacao)
        {
            this._bairro = bairro;
            this._enumTipoOperacao = tipoOperacao;
            InitializeComponent();
        }

        private void btnCadastrarBairro_Click(object sender, EventArgs e)
        {
            switch (_enumTipoOperacao)
            {
                case EnumTipoOperacao.Novo:
                    var txt = ValidaCampos.ValidarTxt(PopularBairro(), GetAllTextBox());
                    if (txt == null)
                    {
                        if (_bairroRepositorio.Salvar(PopularBairro()))
                        {
                            this.DialogResult = DialogResult.Yes;

                        }
                        else
                            CustomMessage
                                .MessageFullComButtonOkIconeDeInformacao("Houve um erro, tente novamente");
                    }
                    else
                        FocarNoTxt(txt:txtNomeBairro);
                    break;
                case EnumTipoOperacao.Editar:
                    break;
                case EnumTipoOperacao.Deletar:
                    break;
                case EnumTipoOperacao.Sair:
                    break;
                case EnumTipoOperacao.Detalhes:
                    break;
                default:
                    break;
            }

        }

        private void FocarNoTxt(TextBox txt)
                => this.FocoNoTxt(txt);
        private TextBox[] GetAllTextBox()
                => new TextBox[] { txtNomeBairro };
        private Bairro PopularBairro()
        {
            return new Bairro
            {
                Nome = txtNomeBairro.Text.Trim().UpperCaseOnlyFirst()
            };
        }

        private void frmCadastrarBairro_Load(object sender, EventArgs e)
        {
            InsBairroRep();
            FocarNoTxt(txtNomeBairro);
        }

        private void txtNomeBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            ValidatorField.IntegerAndLetter(e);
        }
    }
}
