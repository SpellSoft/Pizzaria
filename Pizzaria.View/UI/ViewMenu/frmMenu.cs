using Pizzaria.Model.Data;
using System;
using System.Linq;
using System.Windows.Forms;

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

            var db = new _DbContext();
            var p = db.Produto.ToList();
        }
    }
}
