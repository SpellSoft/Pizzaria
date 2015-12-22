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

namespace Pizzaria.View.UI.ViewSabor
{
    public partial class frmCadastrarSabor : Form
    {
        

        public frmCadastrarSabor()
        {
            InitializeComponent();
        }

        private void frmCadastrarSabor_Load(object sender, EventArgs e)
        {

        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            var sab = new SaborRepositorio();
           bool result = sab.Salvar(new Sabor { Nome = txtNome.Text });
            if (result)
            {
                this.DialogResult = DialogResult.Yes;
            }

        }
    }
}
