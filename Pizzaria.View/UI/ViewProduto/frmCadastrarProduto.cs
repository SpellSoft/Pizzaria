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

namespace Pizzaria.View.UI.ViewProduto
{
    public partial class frmCadastrarProduto : Form
    {


        public frmCadastrarProduto()
        {
            InitializeComponent();
        }
        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
            CarregarCategoria();
            CarregarSabor();
            CarregarBorda();
            gpbEstoque.Visible = false;
            CarregarCbbTipoCadastro();
            MudarPosicaoDoButton(btnCadastrar, new Point(12, 402));
            MudarTamanhoDoForm(new Size(752, 490));

        }
        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            try
            {
                ValidandoTxt(PopularProduto(), new ComplementoRepositorio().GetUltimoResgistro());
            }
            catch (CustomException error)
            {
                FocarNoTxt(ValidarTxt(error.Message, Color.Yellow));
            }
            catch (Exception error)
            {
                SaveErroInTxt.RecordInTxt(error, this.GetType().Name);
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

                return new Produto
                {
                    Nome = txtNome.Text,
                    Codigo = txtCodigo.Text,
                    CategoriaID = new CategoriaRepositorio().GetIDCategoriaPorNome(cbbCategoria.Text),
                    Descricao = txtDescricao.Text,
                    Estoque = new Estoque
                    {
                        Gerenciar = ckbGerenciar.Checked,
                        Quantidade = Convert.ToInt32(txtQtd.Text == "" ? "0" : txtQtd.Text),
                        QuantidadeMinima = Convert.ToInt32(txtQtdMin.Text == "" ? "0" : txtQtdMin.Text),
                        QuantidadeMaxima = Convert.ToInt32(txtQtdMax.Text == "" ? "0" : txtQtdMax.Text)
                    },
                    PrecoCompra = Convert.ToDouble(txtPrecoCompra.Text == "" ? "0" : txtPrecoCompra.Text),
                    PrecoVenda = Convert.ToDouble(txtPeco.Text == "" ? "0" : txtPeco.Text),
                    SaborID = GetTipoProdutoNoCbbProduto(EnumTipoProduto.Pizza) == true
                                  || GetTipoProdutoNoCbbProduto(EnumTipoProduto.Pastel) ?
                                  new SaborRepositorio().GetIDCategoriaPorNome(cbbSabor.Text) :
                                  0,
                    BordaID = GetTipoProdutoNoCbbProduto(EnumTipoProduto.Pizza) == true ?
                                  new BordaRepositorio().getIDPorNome(cbbBorda.Text) :
                                  0



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
        public bool GetTipoProdutoNoCbbProduto(EnumTipoProduto enumProduto)
        {
            return (cbbTipoProduto.Text == enumProduto.ToString());
        }
        private void ValidandoTxt(Produto prod, Complemento com)
        {

            try
            {

                TextBox txt = ValidaCampos.Validar(prod, GetAllTextBox());
                if (txt == null)
                {
                    if (DialogMessage.MessageFullQuestion("Deseja adicionar um complemento?", "Aviso") == DialogResult.Yes)
                    {
                        if (OpenMdiForm.OpenForWithShowDialog(new frmCadastrarComplemento()) == DialogResult.Yes)
                        {
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
                    if (new ProdutoRepositorio().Salvar(prod))
                    {
                        DialogMessage.MessageFullComButtonOkIconeDeInformacao("Produto cadastrado com sucesso!", "Aviso");
                        Array.ForEach(GetAllTextBox(), c => c.Text = string.Empty);
                    }
                }
                else
                {
                    FocarNoTxt(txt);
                }
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
               => new TextBox[] { txtNome, txtCodigo, txtPrecoCompra, txtPeco, txtDescricao, txtQtd, txtQtdMin, txtQtdMax };


        private void MudarPosicaoDoButton(Button btn, Point location)
        {
            GerenciarButton.MudarPosicao(btn, location);
        }

        private void MudarTamanhoDoForm(Size size)
        {
            GerenciarForm.MudarTamanho(this, size);
        }

        private void CarregarCbbTipoCadastro()
        {
            cbbTipoProduto.DataSource = new string[]
            {
                "Pizza",
                "Pastel",
                "Outros"
            };
        }

        private void CarregarBorda()
        {
            var bordaRepositorio = new BordaRepositorio();
            cbbBorda.DisplayMember = "Nome";
            cbbBorda.DataSource = bordaRepositorio.Listar();
        }

        private void CarregarSabor()
        {
            var saborRepositorio = new SaborRepositorio();
            cbbSabor.DisplayMember = "Nome";
            cbbSabor.DataSource = saborRepositorio.Listar();
        }

        private void CarregarCategoria()
        {
            var categoriaRepositorio = new CategoriaRepositorio();
            cbbCategoria.DisplayMember = "Nome";
            cbbCategoria.DataSource = categoriaRepositorio.Listar();
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
                MudarPosicaoDoButton(btn: btnCadastrar, location: new Point(12, 470));
                MudarTamanhoDoForm(size: new Size(754, 565));
            }
            else
            {
                MudarPosicaoDoButton(btnCadastrar, new Point(12, 402));
                MudarTamanhoDoForm(new Size(752, 490));
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
                    DesabilitarOuHablitarGroupBox(gpb: gpbBorda, desabilitar: true);
                    DesabilitarOuHablitarGroupBox(gpb: gpbSabor, desabilitar: true);
                    break;
                case EnumTipoProduto.Pastel:
                    DesabilitarOuHablitarGroupBox(gpb: gpbBorda);
                    DesabilitarOuHablitarGroupBox(gpb: gpbSabor, desabilitar: true);
                    break;
                case EnumTipoProduto.Outros:
                    DesabilitarOuHablitarGroupBox(gpb: gpbBorda);
                    DesabilitarOuHablitarGroupBox(gpb: gpbSabor);
                    break;
                default:
                    break;
            }
        }

        private void DesabilitarOuHablitarGroupBox(GroupBox gpb, bool desabilitar = false)
        {
            GerenciarComboBox.DesabilitarOuHabilitar(gpb, desabilitar);
        }
    }
}
