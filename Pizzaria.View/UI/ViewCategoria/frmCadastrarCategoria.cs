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

namespace Pizzaria.View.UI.ViewCategoria
{
    public partial class frmCadastrarCategoria : Form
    {
        public frmCadastrarCategoria()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var rep = new CategoriaRepositorio();
            var result = rep.Salvar(new Categoria { Nome = txtNome.Text  });
            if (result)
            {
                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}
