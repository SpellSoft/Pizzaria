using Mike.Utilities.Desktop;
using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using Pizzaria.Model.Utilities;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Pizzaria.View.UI.ViewSabor
{
    public partial class frmCadastrarSabor : Form
    {
        

        public frmCadastrarSabor()
        {
            InitializeComponent();
        }

        private void frmCadastrarSabor_Load(object sender, EventArgs e)
        {
            FocarNoTxt(txtNome);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var saborRepositorio = new SaborRepositorio();
            var sabor = new Sabor { Nome = txtNome.Text.Trim().UpperCaseOnlyFirst() };
            var txt = ValidaCampos.Validar(sabor, GetAllTextBox());
            if (txt == null)
            {
                if (saborRepositorio.Salvar(sabor))
                {
                    this.DialogResult = DialogResult.Yes;
                }
            }
            else
                FocarNoTxt(txtNome);

        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            ValidatorField.Letter(e);
        }
        private TextBox[] GetAllTextBox()
                          => new TextBox[] { txtNome };
        private void FocarNoTxt(TextBox txt) => this.FocoNoTxt(txt);

     
    }
}
