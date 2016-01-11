using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.View.UI.ViewCliente
{
  

    public partial class frmCadastrarCliente : Form
    {
        private CidadeRepositorio _cidadeRepositorio;
        private ClienteRepositorio _clienteRepositorio;
        private CidadeRepositorio InsCidadeRep()
                => _cidadeRepositorio = new CidadeRepositorio();
        private ClienteRepositorio InsClienteRep()
                => _clienteRepositorio = new ClienteRepositorio();
        public frmCadastrarCliente()
        {
            InitializeComponent();
        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {
            CarregarCidade();
        }

        private void CarregarCidade()
        {
            cbbCidade.DisplayMember = nameof(Cidade.Nome);
            cbbCidade.DataSource = _cidadeRepositorio.Listar();
        }
    }
}
