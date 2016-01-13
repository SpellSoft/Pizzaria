using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.Utilities;

namespace Pizzaria.View.UI.ViewBorda
{
    public partial class frmCadastrarBorda : Form
    {
        public frmCadastrarBorda()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var borda = new Borda
            {
                Nome = txtNome.Text.Trim().UpperCaseOnlyFirst(),
                Preco = txtPrecoComplemento.Text.Trim().Length > 0 ? Convert.ToDecimal(txtPrecoComplemento.Text.Trim()) : 0,
                Descricao = txtDescricaoComplemento.Text.Trim().UpperCaseOnlyFirst()
            };
            var txt = ValidaCampos.ValidarTxt(borda, GetAllTextBox());
            if (txt == null)
            {
                DialogResult = new BordaRepositorio().Salvar(borda) == true ? DialogResult.Yes : DialogResult.No;
            }
            else
                FocarNoTxt(txt:txt as TextBox);

        }

        private void FocarNoTxt(TextBox txt)
                     => this.FocoNoTxt(txt);
                   

        public TextBox[] GetAllTextBox()
                         => new TextBox[] { txtNome,txtPrecoComplemento,txtDescricaoComplemento};

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            ValidatorField.Letter(e);
        }

        private void txtPrecoComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.NoVirgula(e: e, sender: sender);
            ValidatorField.Money(e: e);
        }

        private void txtDescricaoComplemento_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.AllowOneSpaceTogether(e, sender);
            ValidatorField.Letter(e: e);
        }
    }
}
