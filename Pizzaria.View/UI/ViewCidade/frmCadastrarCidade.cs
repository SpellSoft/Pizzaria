using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using System;
using System.Windows.Forms;

namespace Pizzaria.View.UI.ViewCidade
{
    public partial class frmCadastrarCidade : Form
    {
        private CidadeRepositorio _cidadeRepositorio;
        private CidadeRepositorio InsCidadeRep()
                => _cidadeRepositorio = new CidadeRepositorio();
        public frmCadastrarCidade()
        {
            InitializeComponent();
        }
        
        private void btnCadastrarCidade_Click(object sender, EventArgs e)
        {
            if (_cidadeRepositorio.Salvar(new Cidade
            { 
                 Nome = txtNomeCidade.Text
            }))
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
                MessageBox.Show("houve um errro");
        }

        private void frmCadastrarCidade_Load(object sender, EventArgs e)
        {
            InsCidadeRep();
        }
    }
}
