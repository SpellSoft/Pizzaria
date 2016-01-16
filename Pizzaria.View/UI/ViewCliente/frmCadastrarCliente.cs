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
using System.Linq;
namespace Pizzaria.View.UI.ViewCliente
{


    public partial class frmCadastrarCliente : Form
    {
        private CidadeRepositorio _cidadeRepositorio;
        private ClienteRepositorio _clienteRepositorio;
        private BairroRepositorio _bairroRepositorio;
        private LogradouroRepositorio _logradouroRepositorio;
        private EnderecoRepositorio _enderecoRepositorio;
        private ContatoRepositorio _contatoRepositorio;
        private ContatoRepositorio InsContatoRep()
                => _contatoRepositorio = new ContatoRepositorio();
        private EnderecoRepositorio InsEnderecoRep()
                => _enderecoRepositorio = new EnderecoRepositorio();
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
                InsEnderecoRep();
                InsContatoRep();

                CarregarBairroLogradouro();
                CarregarCidade();
                CarregarBairro();


                switch (_enumTipoOperacao)
                {
                    case EnumTipoOperacao.Novo:
                        break;
                    case EnumTipoOperacao.Editar:

                        MudarTextDoButton(btn: btnCadastrar, text: EnumTipoOperacao.Editar.ToString());
                        MudarIconeDoButton(btnCadastrar, EnumTipoOperacao.Editar, EnumTipoIconCrud.Editar.SetIcon(EnumExtensao.ico));
                        PadronizarButton();
                        PopularTxt();
                        break;
                    case EnumTipoOperacao.Deletar:

                        MudarTextDoButton(btn: btnCadastrar, text: EnumTipoOperacao.Deletar.ToString());
                        MudarIconeDoButton(btnCadastrar, EnumTipoOperacao.Deletar, EnumTipoIconCrud.Deletar.SetIcon(EnumExtensao.ico));
                        PadronizarButton();
                        PopularTxt();
                        EnableOrDisableGroupBox(gpbList: GetAllComboBox());
                        break;
                    case EnumTipoOperacao.Sair:

                        MudarTextDoButton(btn: btnCadastrar, text: EnumTipoOperacao.Sair.ToString());
                        MudarIconeDoButton(btnCadastrar, EnumTipoOperacao.Sair, EnumTipoIconCrud.Sair.SetIcon(EnumExtensao.ico));
                        PadronizarButton();
                        PopularTxt();
                        EnableOrDisableGroupBox(gpbList: GetAllComboBox());
                        break;
                    case EnumTipoOperacao.Detalhes:

                        MudarTextDoButton(btn: btnCadastrar, text: EnumTipoOperacao.Sair.ToString());
                        MudarIconeDoButton(btnCadastrar, EnumTipoOperacao.Sair, EnumTipoIconCrud.Sair.SetIcon(EnumExtensao.ico));
                        PadronizarButton();
                        PopularTxt();
                        EnableOrDisableGroupBox(gpbList:GetAllComboBox());
                        break;

                }

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

        private void EnableOrDisableGroupBox(GroupBox[] gpbList,bool habitar = false)
        {
            GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(gpbList.ToList(), habitar);
        }

        private GroupBox[] GetAllComboBox()
        {
            return new GroupBox[] {gpbContatos,gpbEndereco,gpbCadastrarCliente};
        }
        private void PopularTxt()
        {
            txtNome.Text = _cliente.Nome;
            txtNumero.Text = _cliente.Endereco.Numero;
            txtPontoReferencia.Text = _cliente.Endereco.Referencia;
            cbbBairro.Text = _bairroRepositorio.GetPeloID(_cliente.Endereco?.BairroID)?.Nome;
            cbbCidade.Text = _cidadeRepositorio.GetPeloID(_cliente.Endereco?.CidadeID)?.Nome;
            cbbLogradouro.Text = _logradouroRepositorio.GetPeloID(_cliente.Endereco?.LogradouroID)?.Nome;
            mtbCelular.Text = _cliente.Contato.Celular;
            mtbFixo.Text = _cliente.Contato.Fixo;
        }

        private void MudarIconeDoButton(Button btn, EnumTipoOperacao tipo, string iconName)
        {
            GerenciarControl.MudarIConeDoButton(btn, tipo, iconeName: iconName);
        }

        private void MudarTextDoButton(Button btn, string text)
                => GerenciarControl.MudarTextoDoButton(btn, text);

        private void PadronizarButton()
                => btnCadastrar.Padronizar();
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
            Cliente cliente = PopularCliente();
            switch (_enumTipoOperacao)
            {
                case EnumTipoOperacao.Novo:
                    
                    if (ValidandoCampos(cliente))
                    {
                        CadastrarCliente(cliente);
                    }
                    else
                        CustomMessage
                            .MessageFullComButtonOkIconeDeInformacao("Houve um erro ao cadastrar um cliente, tente novamente");
                   
                    break;
                case EnumTipoOperacao.Editar:
                    if (ValidandoCampos(cliente))
                    {
                        EditarCliente(cliente);
                    }
                    else
                        CustomMessage
                            .MessageFullComButtonOkIconeDeInformacao("Houve um erro ao cadastrar um cliente, tente novamente");
                    break;
                case EnumTipoOperacao.Deletar:
                 
                        DeletarCliente();
                    
                    break;
                case EnumTipoOperacao.Sair:
                    break;
                case EnumTipoOperacao.Detalhes:
                    break;

            }

        }

        private void DeletarCliente()
        {
            if (_clienteRepositorio.Deletar(_cliente?.ClienteID))
            {
                CustomMessage
                    .MessageFullComButtonOkIconeDeInformacao($"Cliente {_cliente.Nome.ToUpper()} foi Deletado com sucesso!");
                this.DialogResult = DialogResult.Yes;
            }
            else
                CustomMessage
                    .MessageFullComButtonOkIconeDeInformacao("Houve um erro ao deletar o cliente, tente novamente.");
        }

        private void EditarCliente(Cliente cliente)
        {
            if (_clienteRepositorio.Editar(cliente))
            {
                _contatoRepositorio.Editar(cliente.Contato);
                _enderecoRepositorio.Editar(cliente.Endereco);
                CustomMessage
                    .MessageFullComButtonOkIconeDeInformacao($"Cliente {cliente.Nome.ToUpper()} foi editado com sucesso!");
                this.DialogResult = DialogResult.Yes;
            }
            else
                CustomMessage
                    .MessageFullComButtonOkIconeDeInformacao("Houve um erro ao editar o cliente, tente novamente.");
        }

        private Cliente PopularCliente()
        {
            return new Cliente
            {
                ClienteID = _cliente != null ? _cliente.ClienteID : 0,
                Nome = txtNome.Text.UpperCaseOnlyFirst().Trim(),
                Contato = new Contato
                {
                    ClienteID = _cliente?.ClienteID ?? 0,
                    Celular = mtbCelular.GetMtbText().Trim(),
                    Fixo = mtbFixo.GetMtbText().Trim()

                },
                Endereco = new Endereco
                {
                    ClienteID = _cliente?.ClienteID ?? 0,
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

        private bool ValidandoCampos(Cliente cliente)
        {
            var txtCli = ValidaCampos.ValidarTxt(cliente, GetAllTxt());
            if (txtCli != null)
            {
                FocarNoTxt(txtCli);
                return false;
                
            }
            var txtCon = ValidaCampos.ValidarTxt(cliente.Endereco, GetAllTxt());
            if (txtCon != null)
            {
                FocarNoTxt(txtCon);
                return false;
            }
            var mtbEnd = ValidaCampos.ValidarMtb(cliente.Contato, GetAllMtb());
            if (mtbEnd != null)
            {
                FocarNoMtb(mtbEnd);
                return false;
            }
            return true;

        }

        private void CadastrarCliente(Cliente cliente)
        {
            if (_clienteRepositorio.Salvar(cliente))
            {
                CustomMessage
                    .MessageFullComButtonOkIconeDeInformacao($"Cliente {cliente.Nome.ToUpper()} foi cadastrado com sucesso!");
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void FocarNoMtb(MaskedTextBox mtbEnd)
                     => this.ActiveControl = mtbEnd;

        private void FocarNoTxt(TextBox txt)
        {
            this.FocoNoTxt(txt);
        }

        private void btnAdicionarCidade_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCidade(null, EnumTipoOperacao.Novo)) == DialogResult.Yes)
            {
                CarregarCidade();
                GetUltimoRegistroCidade();
                CustomMessage.
                     MessageFullComButtonOkIconeDeInformacao("Cidade cadastrado com sucesso!");
            }

        }

        private void GetUltimoRegistroCidade()
        {
            string cidadeNome = _cidadeRepositorio.GetUltimoRegistro();
            cbbCidade.Text = cidadeNome;
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
