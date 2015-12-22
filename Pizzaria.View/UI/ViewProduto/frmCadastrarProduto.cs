using Mike.Utilities.Desktop;
using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;
using Pizzaria.View.UI.ViewSabor;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace Pizzaria.View.UI.ViewProduto
{
    public partial class frmCadastrarProduto : Form
    {
        public frmCadastrarProduto()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var control = new ProdutoRepositorio();
            var prod = new Produto
            {
                Nome = txtNome.Text,
                Codigo = txtCodigo.Text,
                CategoriaID = 1,
                Complemento = new List<Complemento>
                    {
                         new Complemento
                         {
                             Descricao = txtDescricaoComplemento.Text,
                              Preco = Convert.ToDouble(txtPrecoComplemento.Text),
                                SaborID = 1
                         }
                    },
                Descricao = txtDescricao.Text,
                Estoque = new Estoque
                {
                    Gerenciar = ckbGerenciar.Checked,
                    Quantidade = Convert.ToInt32(txtQtd.Text),
                    QuantidadeMaxima = Convert.ToInt32(txtQtdMax.Text),
                    QuantidadeMinima = Convert.ToInt32(txtQtdMin.Text)
                },
                PrecoCompra = Convert.ToDouble(txtCusto.Text),
                PrecoVenda = Convert.ToDouble(txtPeco.Text)



            };
           
            IList<ValidationResult> erros = new List<ValidationResult>();

            if (!Validator.TryValidateObject(prod, new ValidationContext(prod), erros, true))
            {

                var errosMessage = "";
                foreach (var c in erros)
                {
                  
                    errosMessage += c.ErrorMessage + "\n";
                }
               
            }
            else
            {
                control.Salvar(prod);
                MessageBox.Show("Validated");
            }


        }

        private void frmCadastrarProduto_Load(object sender, EventArgs e)
        {
            var cat = new CategoriaRepositorio();
            cbbCategoria.DisplayMember = "Nome";
            cbbCategoria.DataSource =  cat.Listar();
            var sab = new SaborRepositorio();
            cbbSabor.DisplayMember = "Nome";
            cbbSabor.DataSource = sab.Listar();
        }

        private void btnAddSabor_Click(object sender, EventArgs e)
        {
           var dia =  OpenMdiForm.OpenForWithShowDialog(new frmCadastrarSabor());
            if (dia == DialogResult.Yes)
            {
                var sab = new SaborRepositorio();
                cbbSabor.DisplayMember = "Nome";
                cbbSabor.DataSource = sab.Listar();
            }
        }
    }
}
