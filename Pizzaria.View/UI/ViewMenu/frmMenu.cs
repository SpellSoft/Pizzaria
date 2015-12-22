using Pizzaria.Model.Data;
using System;
using System.Linq;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.UI.ViewProduto;

namespace Pizzaria.View.UI.ViewMenu
{
    public partial class frmMenu : Form
    {
        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {          

            
        }

        private void btnGerenciarProduto_Click(object sender, EventArgs e)
        {
            OpenMdiForm.LoadNewKeepAnother(this, new frmCadastrarProduto());
        }
    }
}
