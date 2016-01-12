using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using System;
using System.Windows.Forms;

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
            if (_logradouroRepositorio.Salvar(new Logradouro
            {
                 Nome = txtNomeLogradouro.Text
            }))
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
                MessageBox.Show("Houve Um erro");
        }

        private void frmCadastrarLogradouro_Load(object sender, EventArgs e)
        {
            InsLogradouroRep();
        }
    }
}
