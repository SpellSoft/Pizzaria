using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using Pizzaria.View.Enumerador;
using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.UI.ViewCidade;
using Pizzaria.View.UI.ViewBairro;
using Pizzaria.View.UI.ViewLogradouro;
using Pizzaria.View.Utilities;

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

            try
            {
                FocarNoTxt(txtNome);
                InsBairroResp();
                InsCidadeRep();
                InsLogradouroRep();
                InsClienteRep();

                CarregarBairroLogradouro();
                CarregarCidade();
                CarregarBairro();
            }
            catch (CustomException error)
            {
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
                DialogMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message, title: "Aviso");
            }

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
                    Celular = mtbCelular.GetMtbText().Trim(),
                    Fixo = mtbFixo.GetMtbText().Trim()

                },
                Endereco = new Endereco
                {
                    ClienteID = _cliente?.ClienteID,
                    BairroID = _bairroRepositorio.ListarIdPorNome(GetCbbBairroText()),
                    CidadeID = _cidadeRepositorio.ListarIdPorNome(GetCbbCidadeText()),
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
            var txtCli = ValidaCampos.ValidarTxt(cliente, GetAllTxt());
            if (txtCli != null)
            {
                FocarNoTxt(txtCli);
                return;
            }
            var txtCon = ValidaCampos.ValidarTxt(cliente.Endereco, GetAllTxt());
            if (txtCon != null)
            {
                FocarNoTxt(txtCon);
                return;
            }
            var mtbEnd = ValidaCampos.ValidarMtb(cliente.Contato, GetAllMtb());
            if (mtbEnd != null)
            {
                FocarNoMtb(mtbEnd);
                return;
            }

            var result = _clienteRepositorio.Salvar(cliente);


        }

        private void FocarNoMtb(MaskedTextBox mtbEnd)
                     => this.ActiveControl = mtbEnd;

        private void FocarNoTxt(TextBox txt)
        {
            this.FocoNoTxt(txt);
        }

        private void btnAdicionarCidade_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCidade()) == DialogResult.Yes)
            {
                CarregarCidade();
                CustomMessage.
                     MessageFullComButtonOkIconeDeInformacao("Cidade cadastrado com sucesso!");
            }

        }

        private void btnAdicionarBairro_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarBairro()) == DialogResult.Yes)
            {
                CarregarBairro();
                CustomMessage.
                     MessageFullComButtonOkIconeDeInformacao("Bairro cadastrado com sucesso!");
            }
        }

        private void btnAdicionarLogradouro_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarLogradouro()) == DialogResult.Yes)
            {
                CarregarBairroLogradouro();
                CustomMessage.
                    MessageFullComButtonOkIconeDeInformacao("Logradouro cadastrado com sucesso!");
            }
        }

        private void CarregarBairroLogradouro()
        {
            cbbLogradouro.DisplayMember = nameof(Logradouro.Nome);
            cbbLogradouro.DataSource = _logradouroRepositorio.Listar();
        }
        private TextBox[] GetAllTxt()
                => new TextBox[] { txtNome, txtNumero, txtPontoReferencia };
        private MaskedTextBox[] GetAllMtb()
                => new MaskedTextBox[] { mtbCelular, mtbFixo };
    }
}
