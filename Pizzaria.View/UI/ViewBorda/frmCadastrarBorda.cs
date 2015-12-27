using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using System;
using System.Windows.Forms;

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
            DialogResult = new BordaRepositorio().Salvar(new Borda
            {
                Nome = txtNome.Text,
                Preco = Convert.ToDouble(txtPrecoComplemento.Text),
                Descricao = txtDescricaoComplemento.Text
            }) == true ? DialogResult.Yes : DialogResult.No;

        }
    }
}
