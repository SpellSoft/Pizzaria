using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using Pizzaria.View.Enumerador;
using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.UI.ViewCidade;
using Pizzaria.View.UI.ViewBairro;
using Pizzaria.View.UI.ViewLogradouro;

namespace Pizzaria.View.UI.ViewCliente
{


    public partial class frmCadastrarCliente : Form
    {
        private CidadeRepositorio _cidadeRepositorio;
        private ClienteRepositorio _clienteRepositorio;
        private BairroRepositorio _bairroRepositorio;
        private LogradouroRepositorio _logradouroRepositorio;

        private LogradouroRepositorio InsLogradouroRep()
                => _logradouroRepositorio = new LogradouroRepositorio();
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
            InsLogradouroRep();
            InsClienteRep();

            CarregarBairroLogradouro();
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
                Nome = txtNome.Text.UpperCaseOnlyFirst().Trim(),
                Contato = new Contato
                {
                    ClienteID = _cliente == null ? 0 : _cliente.ClienteID,
                    Celular = mtbCelular.Text.Trim(),
                    Fixo = mtbFixo.Text.Trim()

                },
                Endereco = new Endereco
                {
                    ClienteID = _cliente?.ClienteID,
                    BairroID = _bairroRepositorio.ListarIdPorNome(GetCbbBairroText()),
                    CidadeID  = _cidadeRepositorio.ListarIdPorNome(GetCbbCidadeText()),
                    LogradouroID = _logradouroRepositorio.ListarIdPorNome(GetCbbLogradourotext()),
                    Numero = txtNumero.Text,
                    Referencia = txtPontoReferencia.Text

                },

            };
        }

        private string GetCbbLogradourotext()
        {
            return cbbLogradouro.Text;
        }

        private string GetCbbCidadeText()
        {
            return cbbCidade.Text;
        }
        private string GetCbbBairroText()
        {
            return cbbBairro.Text;
        }

        private void ValidandoCampos(Cliente cliente)
        {
           
            var result = _clienteRepositorio.Salvar(cliente);
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

        private void btnAdicionarLogradouro_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarLogradouro()) == DialogResult.Yes)
            {
                CarregarBairroLogradouro();
                MessageBox.Show("Uma logradouro foi cadastrada");
            }
        }

        private void CarregarBairroLogradouro()
        {
            cbbLogradouro.DisplayMember = nameof(Logradouro.Nome);
            cbbLogradouro.DataSource = _logradouroRepositorio.Listar();
        }
    }
}
