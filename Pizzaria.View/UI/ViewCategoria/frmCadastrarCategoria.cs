using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.Utilities;

namespace Pizzaria.View.UI.ViewCategoria
{
    public partial class frmCadastrarCategoria : Form
    {
        public frmCadastrarCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var categoriaRepositorio = new CategoriaRepositorio();
            var categoria = new Categoria { Nome = txtNome.Text.Trim().UpperCaseOnlyFirst() };
            var txt = ValidaCampos.ValidarTxt(categoria, GetAllTextBox());
            if (txt == null)
            {
                if (categoriaRepositorio.Salvar(categoria))
                {
                    this.DialogResult = DialogResult.Yes;
                }
            }
            else
                FocarNoTxt(txt:txtNome);
       
        }

        private void FocarNoTxt(TextBox txt)
        {
            this.FocoNoTxt(txt);
        }

        private TextBox[] GetAllTextBox()
                     => new TextBox[] { txtNome};

        private void frmCadastrarCategoria_Load(object sender, EventArgs e)
        {
            FocarNoTxt(txtNome);
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            ValidatorField.Letter(e);
        }
    }
}
