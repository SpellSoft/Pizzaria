using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using System;
using System.Windows.Forms;

namespace Pizzaria.View.UI.ViewBairro
{
    public partial class frmCadastrarBairro : Form
    {
        private BairroRepositorio _bairroRepositorio;

        private BairroRepositorio InsBairroRep()
                => _bairroRepositorio = new BairroRepositorio();
        public frmCadastrarBairro()
        {
            InitializeComponent();
        }

        private void btnCadastrarBairro_Click(object sender, EventArgs e)
        {
            if (_bairroRepositorio.Salvar(new Bairro
            {
                 Nome = txtNomeBairro.Text
            }))
            {
                this.DialogResult = DialogResult.Yes;

            }
            else
                MessageBox.Show("Houve um erro");
        }

        private void frmCadastrarBairro_Load(object sender, EventArgs e)
        {
            InsBairroRep();
        }
    }
}
