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
            var txt = ValidaCampos.ValidarTxt(PopularBairro(), GetAllTextBox());
            switch (_enumTipoOperacao)
            {
                case EnumTipoOperacao.Novo:
                  
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
                    
                    if (txt == null)
                    {
                        if (_bairroRepositorio.Editar(PopularBairro()))
                        {
                            this.DialogResult = DialogResult.Yes;

                        }
                        else
                            CustomMessage
                                .MessageFullComButtonOkIconeDeInformacao("Houve um erro, tente novamente");
                    }
                    else
                        FocarNoTxt(txt: txtNomeBairro);

                    break;
                case EnumTipoOperacao.Deletar:
                    if (_bairroRepositorio.Deletar(PopularBairro().BairroID))
                    {
                        this.DialogResult = DialogResult.Yes;

                    }
                    else
                        CustomMessage
                            .MessageFullComButtonOkIconeDeInformacao("Houve um erro, tente novamente");

                    break;
                case EnumTipoOperacao.Sair:
                   
                    break;
                case EnumTipoOperacao.Detalhes:
                  
                    break;
               
            }

        }

        private void PupularTextBox()
        {
            txtNomeBairro.Text = _bairro.Nome;
        }

        private void DesabilitarTxt()
        {
            Array.ForEach(GetAllTextBox(), c => c.Enabled = false);
        }

        private void FocarNoTxt(TextBox txt)
                => this.FocoNoTxt(txt);
        private TextBox[] GetAllTextBox()
                => new TextBox[] { txtNomeBairro };
        private Bairro PopularBairro()
        {
            return new Bairro
            {
                BairroID = _bairro.BairroID ?? 0,
                Nome = txtNomeBairro.Text.Trim().UpperCaseOnlyFirst()
            };
        }

        private void frmCadastrarBairro_Load(object sender, EventArgs e)
        {
            InsBairroRep();
            FocarNoTxt(txtNomeBairro);
            
            switch (_enumTipoOperacao)
            {
                case EnumTipoOperacao.Novo:
                    break;
                case EnumTipoOperacao.Editar:
                    MudarNomeDoButton(EnumTipoOperacao.Editar.ToString());
                    PadronizarButton();
                    MudarIConeDoButton(btnCadastrarBairro, EnumTipoOperacao.Editar, EnumTipoIconCrud.Editar.SetIcon(EnumExtensao.ico));
                    PupularTextBox();
                    break;
                case EnumTipoOperacao.Deletar:
                    DesabilitarTxt();
                    MudarNomeDoButton(EnumTipoOperacao.Deletar.ToString());
                    PadronizarButton();
                    MudarIConeDoButton(btnCadastrarBairro, EnumTipoOperacao.Deletar, EnumTipoIconCrud.Deletar.SetIcon(EnumExtensao.ico));
                    PupularTextBox();
                    break;
                case EnumTipoOperacao.Sair:
                    DesabilitarTxt();
                    MudarNomeDoButton(EnumTipoOperacao.Sair.ToString());
                    PadronizarButton();
                    MudarIConeDoButton(btnCadastrarBairro, EnumTipoOperacao.Sair, EnumTipoIconCrud.Sair.SetIcon(EnumExtensao.ico));
                    PupularTextBox();
                    break;
                case EnumTipoOperacao.Detalhes:
                    DesabilitarTxt();
                    MudarNomeDoButton(EnumTipoOperacao.Detalhes.ToString());
                    PadronizarButton();
                    MudarIConeDoButton(btnCadastrarBairro, EnumTipoOperacao.Detalhes, EnumTipoIconCrud.Sair.SetIcon(EnumExtensao.ico));
                    PupularTextBox();
                    break;
            }
        }

        private void MudarIConeDoButton(Button btn, EnumTipoOperacao enumOperacao, string nomeIcone)
        {
            GerenciarControl.MudarIConeDoButton(btn,enumOperacao,nomeIcone);
        }

        private void MudarNomeDoButton(string texto)
        {
            GerenciarControl.MudarTextoDoButton(btnCadastrarBairro, texto);
        }

        private void PadronizarButton()
                => btnCadastrarBairro.Padronizar();

        private void txtNomeBairro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            ValidatorField.IntegerAndLetter(e);
        }
    }
}
