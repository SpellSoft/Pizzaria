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
using Pizzaria.Model.Utilities;
using System.Drawing;
using System.Linq;
using Pizzaria.View.Enumerador;
using Pizzaria.View.Utilities;
using Pizzaria.View.UI.ViewEspera;

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

        public frmCadastrarProduto()
        {
            InitializeComponent();
        }
        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {

            try
            {
                CarregarCategoria();
                CarregarSabor();
                CarregarBorda();
                gpbEstoque.Visible = false;
                CarregarCbbTipoCadastro();
                GerenciarControl.MudarPosicaoDoButton(btnCadastrar, new Point(12, 402));
                GerenciarControl.MudarTamanhoDoForm(this, new Size(752, 490));

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

     
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                ValidandoTxt(PopularProduto());
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
                    Nome = txtNome.Text.Trim().Length > 0 ? txtNome.Text.UpperCaseOnlyFirst().Trim() : "",
                    Codigo = txtCodigo.Text.Trim(),
                    CategoriaID = _categoriaRepositorio.GetIDCategoriaPorNome(cbbCategoria.Text),
                    Descricao = txtDescricao.Text.Trim().Length > 0 ? txtDescricao.Text.UpperCaseOnlyFirst().Trim() : null ,
                    Estoque = ckbGerenciar.Checked ? new Estoque
                    {
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
        public bool GetTipoProdutoNoCbbTipo(EnumTipoProduto enumProduto)
        {
            return (cbbTipoProduto.Text == enumProduto.ToString());
        }
        public bool GetTipoDeBorda(string sabor)
        {
            return (cbbBorda.Text == sabor);
        }
        private void ValidandoTxt(Produto prod)
        {

            try
            {

                TextBox txt = ValidaCampos.Validar(prod, GetAllTextBox());
                if (txt == null)
                {
                    if (GetTipoProdutoNoCbbTipo(EnumTipoProduto.Pizza))
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
                            }
                        }
                    }
                    InsProdutodRep();
                    if (_produtoRepositorio.Salvar(prod))
                    {
                        CustomMessage.MessageFullComButtonOkIconeDeInformacao("Produto cadastrado com sucesso!", "Aviso");
                        Array.ForEach(GetAllTextBox(), c => c.Text = string.Empty);
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



        public void FocarNoTxt(TextBox txt)
                    => this.FocoNoTxt(txt);
        public TextBox[] GetAllTextBox()
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
            }
        }

        private void btnAddCategoria_Click(object sender, EventArgs e)
        {

            if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarCategoria()) == DialogResult.Yes)
            {
                CarregarCategoria();
            }
        }

        private void ckbGerenciar_CheckedChanged(object sender, EventArgs e)
        {
            var result = gpbEstoque.Visible = (sender as CheckBox).Checked == true ? true : false;

            if (result)
            {
                ModificarTextoDoEstoque(text: "0");
                GerenciarControl.MudarPosicaoDoButton(btn: btnCadastrar, location: new Point(12, 470));
                GerenciarControl.MudarTamanhoDoForm(this, size: new Size(754, 565));
                FocarNoTxt(txtQtd);
            }
            else
            {
                GerenciarControl.MudarPosicaoDoButton(btnCadastrar, new Point(12, 402));
                GerenciarControl.MudarTamanhoDoForm(this, new Size(752, 490));
                FocarNoTxt(txtNome);
            }
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
            }
        }

        private void cbbTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch ((EnumTipoProduto)Enum.Parse(typeof(EnumTipoProduto), cbbTipoProduto.Text))
            {
                case EnumTipoProduto.Pizza:
                    GerenciarControl.DesabilitarOuHablitarCheckBox(ckb: ckbGerenciar, habilitado: true);
                    GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(listGpb: ListarGroupBox(), mostrar: true);
                    GerenciarControl.DesabilitarButton(btn: btnCadastrar, habilitado: true);
                    FocarNoTxt(txt: txtNome);
                    break;
                case EnumTipoProduto.Pastel:
                    GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(listGpb: ListarGroupBox(), mostrar: true);
                    GerenciarControl.DesabilitarOuHablitarCheckBox(ckb: ckbGerenciar, habilitado: true);
                    DesabilitarPastel();
                    GerenciarControl.DesabilitarButton(btn: btnCadastrar, habilitado: true);
                    FocarNoTxt(txt: txtNome);
                    break;
                case EnumTipoProduto.Outros:
                    GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(listGpb: ListarGroupBox(), mostrar: true);
                    GerenciarControl.DesabilitarOuHablitarCheckBox(ckb: ckbGerenciar, habilitado: true);
                    DesabilitarOutros();
                    GerenciarControl.DesabilitarButton(btn: btnCadastrar, habilitado: true);
                    FocarNoTxt(txt: txtNome);
                    break;
                case EnumTipoProduto.Escolha:
                    GerenciarControl.DesabilitarOuHabilitarMuitosGroupBox(listGpb: ListarGroupBox());
                    GerenciarControl.DesabilitarOuHablitarCheckBox(ckb: ckbGerenciar);
                    GerenciarControl.DesabilitarButton(btn: btnCadastrar);
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
