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
                ValidandoTxt(PopularProduto());
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
                    Estoque = ckbGerenciar.Checked ? new Estoque
                    {
                        Gerenciar = ckbGerenciar.Checked,
                        Quantidade = Convert.ToInt32(txtQtd.Text == "" ? "0" : txtQtd.Text),
                        QuantidadeMinima = Convert.ToInt32(txtQtdMin.Text == "" ? "0" : txtQtdMin.Text),
                        QuantidadeMaxima = Convert.ToInt32(txtQtdMax.Text == "" ? "0" : txtQtdMax.Text)
                    } : null,
                    PrecoCompra = Convert.ToDouble(txtPrecoCompra.Text == "" ? "0" : txtPrecoCompra.Text),
                    PrecoVenda = Convert.ToDouble(txtPeco.Text == "" ? "0" : txtPeco.Text),
                    SaborID = GetTipoProdutoNoCbbProduto(EnumTipoProduto.Pizza) == true
                                  || GetTipoProdutoNoCbbProduto(EnumTipoProduto.Pastel) ?
                                  new SaborRepositorio()?.GetIDCategoriaPorNome(cbbSabor.Text) :
                                  null,
                    BordaID = GetTipoProdutoNoCbbProduto(EnumTipoProduto.Pizza) == true ?
                                  new BordaRepositorio()?.getIDPorNome(cbbBorda.Text) :
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
        public bool GetTipoProdutoNoCbbProduto(EnumTipoProduto enumProduto)
        {
            return (cbbTipoProduto.Text == enumProduto.ToString());
        }
        private void ValidandoTxt(Produto prod)
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
                            Complemento com = new ComplementoRepositorio().GetUltimoResgistro();
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
               => new TextBox[]
               {
                   txtNome,
                   txtCodigo,
                   txtPrecoCompra,
                   txtPeco,
                   txtDescricao,
                   txtQtd,
                   txtQtdMin,
                   txtQtdMax
               };


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
               EnumTipoProduto.Escolha.ToString(),
                EnumTipoProduto.Pizza.ToString(),
                EnumTipoProduto.Pastel.ToString(),
                EnumTipoProduto.Outros.ToString()
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
                FocarNoTxt(txtQtd);
            }
            else
            {
                MudarPosicaoDoButton(btnCadastrar, new Point(12, 402));
                MudarTamanhoDoForm(new Size(752, 490));
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
                    DesabilitarOuHablitarCheckBox(ckb: ckbGerenciar, habilitado: true);
                    DesabilitarOuHabilitarMuitosGroupBox(listGpb: ListarGroupBox(), mostrar: true);
                    DesabilitarButton(btn: btnCadastrar, habilitado: true);
                    FocarNoTxt(txt:txtNome);
                    break;
                case EnumTipoProduto.Pastel:   
                    DesabilitarOuHabilitarMuitosGroupBox(listGpb: ListarGroupBox(), mostrar: true);                    
                    DesabilitarOuHablitarCheckBox(ckb: ckbGerenciar,habilitado:true);
                    DesabilitarPastel();
                    DesabilitarButton(btn: btnCadastrar, habilitado: true);
                    FocarNoTxt(txt: txtNome);
                    break;
                case EnumTipoProduto.Outros:
                    DesabilitarOuHabilitarMuitosGroupBox(listGpb: ListarGroupBox(),mostrar:true);
                    DesabilitarOuHablitarCheckBox(ckb: ckbGerenciar, habilitado: true);
                    DesabilitarOutros();
                    DesabilitarButton(btn: btnCadastrar,habilitado:true);
                    FocarNoTxt(txt: txtNome);
                    break;
                case EnumTipoProduto.Escolha:
                    DesabilitarOuHabilitarMuitosGroupBox(listGpb: ListarGroupBox());                   
                    DesabilitarOuHablitarCheckBox(ckb:ckbGerenciar);
                    DesabilitarButton(btn:btnCadastrar);       
                    break;
              
            }
        }

        private void FocarNoButton(Button btn)
        {
            throw new NotImplementedException();
        }

        private void DesabilitarButton(Button btn, bool habilitado = false)
        {
            btn.Enabled = habilitado;
        }

        private void DesabilitarPastel()
        {
            DesabilitarOuHabilitarMuitosGroupBox(listGpb: new List<GroupBox> {gpbBorda });
        }

        private void DesabilitarOutros()
        {
            DesabilitarOuHabilitarMuitosGroupBox(listGpb: new List<GroupBox> {gpbBorda,gpbSabor });
        }

        private void DesabilitarOuHabilitarMuitosGroupBox(List<GroupBox> listGpb,bool mostrar = false)
        {
            GerenciarGroupBox.DesabilitarOuHabilitarMuitos(listGpb, mostrar);
        }

        private void DesabilitarOuHablitarCheckBox(CheckBox ckb,bool habilitado = false)
        {
            ckbGerenciar.Enabled = habilitado;
        }

        private void EsconderOuMostrarCheckBox(CheckBox ckb,bool mostrar = false)
        {
            ckb.Visible = mostrar;
        }
        public void EsconderOuMostrarGroupBox(GroupBox gpb,bool mostrar = false)
        {
            GerenciarGroupBox.EsconderOuMostrar(gpb, mostrar);
        }

        private void EsconderOuMostrarMuitosGroupBox(List<GroupBox> list,bool mostrar = false)
        {
            GerenciarGroupBox.EsconderOuMostrarMuitos(ListarGroupBox(), mostrar);
            //if (ckbGerenciar.Visible && ckbGerenciar.Checked)
            //{
            //    EsconderOuMostrarGroupBox(gpbEstoque, true);fg
            //}
            //else if(ckbGerenciar.Visible && ckbGerenciar.Checked == false)
            //{
            //    EsconderOuMostrarGroupBox(gpbEstoque, false);
            //}
            //else
            //{
            //    EsconderOuMostrarGroupBox(gpbEstoque, false);
            //}
        }

        private List<GroupBox> ListarGroupBox()
        {
            return new List<GroupBox> { gpbBorda, gpbCategoria, gpbEstoque,gpbPrecoVenda, gpbSabor,gpbProduto };
        }
        private void DesabilitarOuHablitarGroupBox(GroupBox gpb, bool desabilitar = false)
        {
            GerenciarGroupBox.DesabilitarOuHabilitar(gpb, desabilitar);
        }
    }
}
