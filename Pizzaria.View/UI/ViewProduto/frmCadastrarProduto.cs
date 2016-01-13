using Mike.Utilities.Desktop;
using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using Pizzaria.View.UI.ViewCategoria;
using Pizzaria.View.UI.ViewSabor;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Pizzaria.View.UI.ViewComplemento;
using Pizzaria.View.UI.ViewBorda;
using System.Drawing;
using System.Linq;
using Pizzaria.View.Enumerador;
using Pizzaria.View.Utilities;

namespace Pizzaria.View.UI.ViewProduto
{
    public partial class frmCadastrarProduto : Form
    {
        private ProdutoRepositorio _produtoRepositorio { get; set; }
        private CategoriaRepositorio _categoriaRepositorio { get; set; }
        private SaborRepositorio _saborRepositorio { get; set; }
        private BordaRepositorio _bordaRepositorio { get; set; }
        private ComplementoRepositorio _complementoRepositorio { get; set; }

        private void InsProdutodRep()
                     => _produtoRepositorio = new ProdutoRepositorio();
        private void InsCategoriaRep()
                => _categoriaRepositorio = new CategoriaRepositorio();
        private void InsSaborRep()
                     => _saborRepositorio = new SaborRepositorio();
        private void InsBordaRep()
                     => _bordaRepositorio = new BordaRepositorio();
        private void InsComplementoRep()
                     => _complementoRepositorio = new ComplementoRepositorio();
        private EnumTipoOperacao _enumTipoOperacao;
        private Produto _produto;
        public frmCadastrarProduto(EnumTipoOperacao enumTipoOperacao, Produto produto)
        {
            this._produto = produto;
            this._enumTipoOperacao = enumTipoOperacao;
            InitializeComponent();
        }
        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {

            try
            {
                switch (_enumTipoOperacao)
                {
                    case EnumTipoOperacao.Novo:
                        CarregarCategoria();
                        CarregarSabor();
                        CarregarBorda();
                        CarregarCbbTipoCadastro();
                        GerenciarControl.EsconderOuMostrarGroupBox(gpbEstoque);
                        GerenciarControl.MudarPosicaoDoButton(btnCadastrar, new Point(12, 402));
                        GerenciarControl.MudarTamanhoDoForm(this, new Size(752, 490));
                        GerenciarControl.DesabilitarOuHabilitarButton(btnCadastrar, true);
                        GerenciarControl.DesabilitarOuHabilitarButton(btnCadastrar, true);
                        break;
                    case EnumTipoOperacao.Editar:
                        GerenciarControl.MudarTextoDoForm(form: this, text: EnumTipoOperacao.Editar.ToString());
                        GerenciarControl.MudarTextoDoButton(btn: btnCadastrar, text: EnumTipoOperacao.Editar.ToString());
                        GerenciarControl.MudarIConeDoButton(btn: btnCadastrar, operecao: EnumTipoOperacao.Editar, iconeName: EnumTipoIconCrud.Editar.SetIcon(EnumExtensao.ico));
                        GerenciarControl.MudarTextoDoGroupBox(gpb: gpbProduto, text: "Editar Produto");
                        PersonalizarButton();
                        PopularTextBox();
                        GerenciarControl.DesabilitarOuHabilitarButton(btnCadastrar, true);
                        GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(new List<GroupBox> { gpbBorda, gpbCategoria, gpbEstoque, gpbPrecoVenda, gpbProduto, gpbSabor }, true);
                        FocarNoTxt(txtNome);
                        break;
                    case EnumTipoOperacao.Deletar:
                        GerenciarControl.MudarTextoDoForm(form: this, text: EnumTipoOperacao.Deletar.ToString());
                        GerenciarControl.MudarTextoDoButton(btn: btnCadastrar, text: EnumTipoOperacao.Deletar.ToString());
                        GerenciarControl.MudarIConeDoButton(btn: btnCadastrar, operecao: EnumTipoOperacao.Deletar, iconeName: EnumTipoIconCrud.Deletar.SetIcon(EnumExtensao.ico));
                        GerenciarControl.MudarTextoDoGroupBox(gpb: gpbProduto, text: "Deletar Produto");
                        PersonalizarButton();
                        PopularTextBox();
                        GerenciarControl.DesabilitarOuHabilitarButton(btnCadastrar, true);
                        FocarNoButton(btnCadastrar);
                        break;
                    case EnumTipoOperacao.Sair:
                        break;
                    case EnumTipoOperacao.Detalhes:
                        GerenciarControl.MudarTextoDoForm(form: this, text: EnumTipoOperacao.Detalhes.ToString());
                        GerenciarControl.MudarTextoDoButton(btn: btnCadastrar, text: EnumTipoOperacao.Sair.ToString());
                        GerenciarControl.MudarIConeDoButton(btn: btnCadastrar, operecao: EnumTipoOperacao.Detalhes, iconeName: EnumTipoIconCrud.Sair.SetIcon(EnumExtensao.ico));
                        GerenciarControl.MudarTextoDoGroupBox(gpb: gpbProduto, text: "Detalhes do Produto");
                        PersonalizarButton();
                        PopularTextBox();
                        GerenciarControl.DesabilitarOuHabilitarButton(btnCadastrar, true);
                        FocarNoButton(btnCadastrar);
                        break;

                }


            }
            catch (CustomException error)
            {
                CustomMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message);
            }
            catch (Exception error)
            {
                CustomMessage.MessageFullComButtonOkIconeDeInformacao(message: error.Message);
            }

        }

        private void PersonalizarButton()
        {
            btnCadastrar.Padronizar();
        }

        private void FocarNoButton(Button btn)
                     => this.FocoNoBotao(btn);
        private void PopularTextBox()
        {
            cbbTipoProduto.DataSource = new string[] { Enum.GetName(typeof(EnumTipoProduto), _produto.TipoProduto) };
            if (_produto.Estoque != null)
                ckbGerenciar.Checked = _produto.Estoque.Gerenciar;
            else
            {
                GerenciarControl.EsconderOuMostrarGroupBox(gpbEstoque);
                MudarTamanhoSemEstoque();
            }
            GerenciarControl.DesabilitarOuHablitarCheckBox(ckbGerenciar);
            cbbCategoria.DataSource = new string[] { _produto.Categoria?.Nome };
            cbbBorda.DataSource = new string[] { _produto.Borda?.Nome };
            cbbSabor.DataSource = new string[] { _produto.Sabor?.Nome };

            txtNome.Text = _produto.Nome;
            txtCodigo.Text = _produto.Codigo;
            txtDescricao.Text = _produto.Descricao;

            HabilitarNormalCaseNoTxtDePrecos();

            if (_enumTipoOperacao == EnumTipoOperacao.Editar)
            {
                txtPrecoCompra.Text = _produto.PrecoCompra.Value.ToString("N2");
                txtPrecoVenda.Text = _produto.PrecoVenda.ToString("N2");
            }
            else
            {
                txtPrecoCompra.Text = _produto.PrecoCompra.Value.ToString("C2");
                txtPrecoVenda.Text = _produto.PrecoVenda.ToString("C2");
            }
            

            txtQtd.Text = _produto.Estoque?.Quantidade.ToString();
            txtQtdMax.Text = _produto.Estoque?.QuantidadeMaxima.ToString();
            txtQtdMin.Text = _produto.Estoque?.QuantidadeMinima.ToString();

            DesabilitarTodosGpb();
        }

        private void DesabilitarTodosGpb()
        {
            GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(GetAllGroupBox().ToList());
        }

        private void HabilitarNormalCaseNoTxtDePrecos()
        {
            txtPrecoCompra.CharacterCasing = CharacterCasing.Normal;
            txtPrecoVenda.CharacterCasing = CharacterCasing.Normal;
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                InsProdutodRep();
                switch (_enumTipoOperacao)
                {
                    case EnumTipoOperacao.Novo:
                        if (SeExisteCategoria())
                        {
                            ValidandoTxt(PopularProduto());
                        }
                        break;
                    case EnumTipoOperacao.Editar:
                        ValidandoTxt(PopularProduto());

                        break;
                    case EnumTipoOperacao.Deletar:
                        if (_produtoRepositorio.Deletar(_produto.ProdutoID))
                        {
                            this.DialogResult = DialogResult.Yes;
                        }
                        break;
                    case EnumTipoOperacao.Sair:
                        FecharForm();
                        break;
                    case EnumTipoOperacao.Detalhes:
                        FecharForm();
                        break;
                    default:
                        break;
                }



            }
            catch (CustomException error)
            {
                FocarNoTxt(ValidarTxt(error.Message, Color.Yellow));
            }
            catch (Exception error)
            {

                ValidarTxt(error.Message, Color.Yellow);

            }

        }

        private void FecharForm()
                     => this.Close();
        private bool SeExisteCategoria()
        {
            InsCategoriaRep();
            if (_categoriaRepositorio.GetQuantidade() > 0)
            {
                return true;
            }
            throw new CustomException("Você deve cadastrar um Categoria");

        }

        private TextBox ValidarTxt(string erro, Color cor)
        {
            return GetAllTextBox().ValidarCampos(erro, cor: cor);
        }

        private Produto PopularProduto()
        {

            try
            {
                InsCategoriaRep();
                InsSaborRep();
                InsBordaRep();
                return new Produto
                {
                    ProdutoID = _produto == null ? 0 :_produto.ProdutoID,
                    TipoProduto = GetHashCodeDoEnumTipoProduto(GetTextCbbTipoProduto()),
                    Nome = txtNome.Text.Trim().Length > 0 ? txtNome.Text.UpperCaseOnlyFirst().Trim() : "",
                    Codigo = txtCodigo.Text.Trim(),
                    CategoriaID = _categoriaRepositorio.GetIDCategoriaPorNome(cbbCategoria.Text),
                    Descricao = txtDescricao.Text.Trim().Length > 0 ? txtDescricao.Text.UpperCaseOnlyFirst().Trim() : null,
                    Estoque = ckbGerenciar.Checked ? new Estoque
                    {
                        ProdutoID = _produto == null ? 0 : _produto.ProdutoID,
                        Gerenciar = ckbGerenciar.Checked,
                        Quantidade = Convert.ToInt32(txtQtd.Text.Trim() == "" ? "0" : txtQtd.Text),
                        QuantidadeMinima = Convert.ToInt32(txtQtdMin.Text.Trim() == "" ? "0" : txtQtdMin.Text),
                        QuantidadeMaxima = Convert.ToInt32(txtQtdMax.Text.Trim() == "" ? "0" : txtQtdMax.Text)
                         
                    } : null,                    
                    PrecoCompra = Convert.ToDecimal(txtPrecoCompra.Text.Trim() == "" ? null : txtPrecoCompra.Text),
                    PrecoVenda = Convert.ToDecimal(txtPrecoVenda.Text.Trim() == "" ? "0" : txtPrecoVenda.Text),
                    SaborID = GetTipoProdutoNoCbbTipo(EnumTipoProduto.Pizza) == true
                                  || GetTipoProdutoNoCbbTipo(EnumTipoProduto.Pastel) ?
                                  _saborRepositorio?.GetIDCategoriaPorNome(cbbSabor.Text) :
                                  null,
                    BordaID = GetTipoProdutoNoCbbTipo(EnumTipoProduto.Pizza) && GetTipoDeBorda(EnumTipoProduto.Escolha.ToString()) == false ?
                                  _bordaRepositorio?.getIDPorNome(cbbBorda.Text) :
                                  null



                };
            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }

        private int GetHashCodeDoEnumTipoProduto(string cbbTipoProdutoText)
                    => Enum.Parse(typeof(EnumTipoProduto), cbbTipoProdutoText).GetHashCode();

        private string GetTextCbbTipoProduto()
                       => cbbTipoProduto.Text;
        private bool GetTipoProdutoNoCbbTipo(EnumTipoProduto enumProduto)
        {
            return (cbbTipoProduto.Text == enumProduto.ToString());
        }
        private bool GetTipoDeBorda(string sabor)
        {
            return (cbbBorda.Text == sabor);
        }
        private void ValidandoTxt(Produto prod)
        {

            try
            {

                TextBox txt = ValidaCampos.ValidarTxt(prod, GetAllTextBox().ToArray<TextBox>());
                if (txt == null)
                {
                    if (GetTipoProdutoNoCbbTipo(EnumTipoProduto.Pizza) && GetTipoOperacao()==EnumTipoOperacao.Novo)
                    {
                        if (CustomMessage.MessageFullQuestion("Deseja adicionar um complemento?", "Aviso") == DialogResult.Yes)
                        {
                            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarComplemento()) == DialogResult.Yes)
                            {

                                InsComplementoRep();
                                Complemento com = _complementoRepositorio.GetUltimoResgistro();
                                prod.Complemento = new List<Complemento>
                                {
                                      new Complemento
                                      {
                                          ComplementoID = com.ComplementoID,
                                          Descricao = com.Descricao,
                                          Preco = com.Preco,
                                          SaborID = com.SaborID
                                      }
                                };
                                _complementoRepositorio.Deletar(com.ComplementoID);
                            }
                        }
                    }
                    InsProdutodRep();
                    if (_enumTipoOperacao == EnumTipoOperacao.Novo ? _produtoRepositorio.Salvar(prod) : _produtoRepositorio.Editar(prod))
                    {
                        CustomMessage.MessageFullComButtonOkIconeDeInformacao(_enumTipoOperacao == EnumTipoOperacao.Novo? "Produto Cadastrado com sucesso!" : "Produto Alterado com sucesso!", "Aviso");
                        this.DialogResult = DialogResult.Yes;
                    }
                    else
                    {
                        CustomMessage
                            .MessageFullComButtonOkIconeDeInformacao("Houve um problema inesperado, tente novamente!", "Aviso");
                    }
                }
                else
                    FocarNoTxt(txt);
            }
            catch (CustomException error)
            {
                throw new CustomException(error.Message);
            }
            catch (Exception error)
            {
                throw new Exception(error.Message);
            }

        }

        private EnumTipoOperacao GetTipoOperacao()
        {
            return _enumTipoOperacao;
        }

        public void FocarNoTxt(TextBox txt)
                    => this.FocoNoTxt(txt);
        private GroupBox[] GetAllGroupBox()
                => new GroupBox[]
                {
                    gpbProduto,gpbEstoque,gpbBorda,gpbCategoria,gpbPrecoVenda,gpbTipoCadastro,gpbSabor
                };
        private TextBox[] GetAllTextBox()
               => new TextBox[]
               {
                   txtNome,
                   txtCodigo,
                   txtPrecoCompra,
                   txtPrecoVenda,
                   txtDescricao,
                   txtQtd,
                   txtQtdMin,
                   txtQtdMax
               };



        private void CarregarCbbTipoCadastro()
        {
            cbbTipoProduto.DataSource = new string[]
            {
                EnumTipoProduto.Escolha.ToString(),
                EnumTipoProduto.Pizza.ToString(),
                EnumTipoProduto.Pastel.ToString(),
                EnumTipoProduto.Outros.ToString()
            };
        }

        private void CarregarBorda()
        {

            var arrayBorda = new List<string> { EnumTipoProduto.Escolha.ToString() };
            InsBordaRep();
            foreach (var txt in _bordaRepositorio.Listar().Select(item => new Borda { Nome = item.Nome }.Nome))
            {
                arrayBorda.Add(txt);
            }
            cbbBorda.DataSource = arrayBorda;
        }

        private void CarregarSabor()
        {
            var arraySabor = new List<string> { EnumTipoProduto.Escolha.ToString() };
            InsSaborRep();
            foreach (var txt in _saborRepositorio.Listar().Select(item => new Sabor { Nome = item.Nome }.Nome))
            {
                arraySabor.Add(txt);
            }
            cbbSabor.DataSource = arraySabor;
        }

        private void CarregarCategoria()
        {
            cbbCategoria.DisplayMember = "Nome";
            InsCategoriaRep();
            cbbCategoria.DataSource = _categoriaRepositorio.Listar();
        }

        private void btnAddSabor_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarSabor()) == DialogResult.Yes)
            {
                CarregarSabor();
                GetUltimoSabor();
            }
        }

        private void GetUltimoSabor()
        {
            InsSaborRep();
            cbbSabor.Text = _saborRepositorio.GetUltimoRegistro();
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {

            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCategoria()) == DialogResult.Yes)
            {
                CarregarCategoria();
                GetUltimaCategoria();
            }
        }

        private void GetUltimaCategoria()
        {
            InsCategoriaRep();
            cbbCategoria.Text = _categoriaRepositorio.GetUltimoRegistro();
        }

        private void ckbGerenciar_CheckedChanged(object sender, EventArgs e)
        {
            var result = gpbEstoque.Visible = (sender as CheckBox).Checked == true ? true : false;

            if (result)
            {
                ModificarTextoDoEstoque(text: "0");
                MudarTamanhoComEstoque();
            }
            else
                MudarTamanhoSemEstoque();
        }

        private void MudarTamanhoSemEstoque()
        {
            GerenciarControl.MudarPosicaoDoButton(btnCadastrar, new Point(12, 402));
            GerenciarControl.MudarTamanhoDoForm(this, new Size(752, 490));
            FocarNoTxt(txtNome);
        }

        private void MudarTamanhoComEstoque()
        {
            GerenciarControl.MudarPosicaoDoButton(btn: btnCadastrar, location: new Point(12, 470));
            GerenciarControl.MudarTamanhoDoForm(this, size: new Size(754, 565));
            FocarNoTxt(txtQtd);
        }

        private void ModificarTextoDoEstoque(string text)
        {
            foreach (TextBox txt in Controls.OfType<GroupBox>()
                    .Where(c => c.Name == "gpbEstoque")
                    .SelectMany(c => c.Controls.OfType<TextBox>()))
            {
                txt.Text = text;
            }
        }

        private void btnAddBorda_Click(object sender, EventArgs e)
        {
            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarBorda()) == DialogResult.Yes)
            {
                CarregarBorda();
                InsBordaRep();
                cbbBorda.Text = _bordaRepositorio.GetUltimoRegistro();
            }
        }

        private void cbbTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch ((EnumTipoProduto)Enum.Parse(typeof(EnumTipoProduto), cbbTipoProduto?.Text))
            {
                case EnumTipoProduto.Pizza:
                    GerenciarControl.DesabilitarOuHablitarCheckBox(ckb: ckbGerenciar, habilitado: true);
                    GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(listGpb: ListarGroupBox(), mostrar: true);
                    GerenciarControl.DesabilitarOuHabilitarButton(btn: btnCadastrar, habilitado: true);
                    FocarNoTxt(txt: txtNome);
                    break;
                case EnumTipoProduto.Pastel:
                    GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(listGpb: ListarGroupBox(), mostrar: true);
                    GerenciarControl.DesabilitarOuHablitarCheckBox(ckb: ckbGerenciar, habilitado: true);
                    DesabilitarPastel();
                    GerenciarControl.DesabilitarOuHabilitarButton(btn: btnCadastrar, habilitado: true);
                    FocarNoTxt(txt: txtNome);
                    break;
                case EnumTipoProduto.Outros:
                    GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(listGpb: ListarGroupBox(), mostrar: true);
                    GerenciarControl.DesabilitarOuHablitarCheckBox(ckb: ckbGerenciar, habilitado: true);
                    DesabilitarOutros();
                    GerenciarControl.DesabilitarOuHabilitarButton(btn: btnCadastrar, habilitado: true);
                    FocarNoTxt(txt: txtNome);
                    break;
                case EnumTipoProduto.Escolha:
                    GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(listGpb: ListarGroupBox());
                    GerenciarControl.DesabilitarOuHablitarCheckBox(ckb: ckbGerenciar);
                    GerenciarControl.DesabilitarOuHabilitarButton(btn: btnCadastrar);
                    break;

            }
        }


        private void DesabilitarPastel()
        {
            GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(listGpb: new List<GroupBox> { gpbBorda });
        }

        private void DesabilitarOutros()
        {
            GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(listGpb: new List<GroupBox> { gpbBorda, gpbSabor });
        }

        private List<GroupBox> ListarGroupBox()
        {
            return new List<GroupBox> { gpbBorda, gpbCategoria, gpbEstoque, gpbPrecoVenda, gpbSabor, gpbProduto };
        }

        private void txtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.IntegerAndLetter(e: e);
            ValidatorField.AllowOneSpaceTogether(e, sender);
        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.IntegerAndLetter(e: e);
            ValidatorField.NoSpace(e);
        }

        private void txtPrecoCompra_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.NoVirgula(e: e, sender: sender);
            ValidatorField.Money(e: e);
        }

        private void txtPeco_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.NoVirgula(e: e, sender: sender);
            ValidatorField.Money(e: e);
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Integer(e: e);
        }

        private void txtQtdMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Integer(e: e);
        }

        private void txtQtdMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.Integer(e: e);
        }

        private void txtDescricao_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidatorField.IntegerAndLetter(e: e);
            ValidatorField.AllowOneSpaceTogether(e, sender);
        }
    }
}
