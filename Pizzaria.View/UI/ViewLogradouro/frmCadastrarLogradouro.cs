using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.Utilities;

namespace Pizzaria.View.UI.ViewLogradouro
{
    public partial class frmCadastrarLogradouro : Form
    {
        private LogradouroRepositorio _logradouroRepositorio;

        public frmCadastrarLogradouro()
        {
            InitializeComponent();
        }
        private LogradouroRepositorio InsLogradouroRep()
                => _logradouroRepositorio = new LogradouroRepositorio();
        private void btnCadastrarCidade_Click(object sender, EventArgs e)
        {
            var txt = ValidaCampos.ValidarTxt(PopularLogradouro(),GetAllTxt());
            if (txt == null)
            {
                if (_logradouroRepositorio.Salvar(PopularLogradouro()))
                {
                    this.DialogResult = DialogResult.Yes;
                }
                else
                    CustomMessage
                        .MessageFullComButtonOkIconeDeInformacao("Houve um problema, tente novamente");
            }

            else
                FocarNoTxt(txtNomeLogradouro);
        }

        private TextBox[] GetAllTxt()
                => new TextBox[] { txtNomeLogradouro };
        private Logradouro PopularLogradouro()
        {
            return new Logradouro
            {
                Nome = txtNomeLogradouro.Text.Trim().UpperCaseOnlyFirst()
            };
        }

        private void frmCadastrarLogradouro_Load(object sender, EventArgs e)
        {
            InsLogradouroRep();
            FocarNoTxt(txt:txtNomeLogradouro);
        }

        private void FocarNoTxt(TextBox txt)
                => this.FocoNoTxt(txt);

        private void txtNomeLogradouro_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            ValidatorField.IntegerAndLetter(e);
        }
    }
}
