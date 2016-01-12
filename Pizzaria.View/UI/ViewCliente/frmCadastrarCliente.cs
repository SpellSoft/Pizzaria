using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using Pizzaria.View.Enumerador;
using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.UI.ViewCidade;
using Pizzaria.View.UI.ViewBairro;

namespace Pizzaria.View.UI.ViewCliente
{


    public partial class frmCadastrarCliente : Form
    {
        private CidadeRepositorio _cidadeRepositorio;
        private ClienteRepositorio _clienteRepositorio;
        private BairroRepositorio _bairroRepositorio;
        private BairroRepositorio InsBairroResp()
                => _bairroRepositorio = new BairroRepositorio();

        private CidadeRepositorio InsCidadeRep()
                => _cidadeRepositorio = new CidadeRepositorio();
        private ClienteRepositorio InsClienteRep()
                => _clienteRepositorio = new ClienteRepositorio();
        private Cliente _cliente;
        private EnumTipoOperacao _enumTipoOperacao;
        public frmCadastrarCliente(Cliente cliente, EnumTipoOperacao enumTipoOperacao)
        {
            this._cliente = cliente;
            this._enumTipoOperacao = enumTipoOperacao;
            InitializeComponent();
        }

        private void frmCadastrarCliente_Load(object sender, EventArgs e)
        {
            InsBairroResp();
            InsCidadeRep();

            CarregarCidade();
            CarregarBairro();
        }

        private void CarregarBairro()
        {
            cbbBairro.DisplayMember = nameof(Bairro.Nome);
            cbbBairro.DataSource = _bairroRepositorio.Listar();
        }

        private void CarregarCidade()
        {
            cbbCidade.DisplayMember = nameof(Cidade.Nome);
            cbbCidade.DataSource = _cidadeRepositorio.Listar();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            ValidandoCampos(PopularCliente());
        }

        private Cliente PopularCliente()
        {
            return new Cliente
            {
                ClienteID = _cliente != null ? _cliente.ClienteID : 0,
                Contato = new Contato
                {
                    ClienteID = _cliente.ClienteID,
                    Celular = mtbCelular.Text,
                    Fixo = mtbFixo.Text

                },
                Endereco = new Endereco
                {
                     CidadeID = _cliente.ClienteID,
                     
                }
            };
        }

        private void ValidandoCampos(Cliente cliente)
        {
            throw new NotImplementedException();
        }

        private void btnAdicionarCidade_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCidade()) == DialogResult.Yes)
            {
                CarregarCidade();
                MessageBox.Show("Uma ciade foi cadastrada");
            }
            
        }

        private void btnAdicionarBairro_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarBairro()) == DialogResult.Yes)
            {
                CarregarBairro();
                MessageBox.Show("Uma ciade foi cadastrada");
            }
        }
    }
}
