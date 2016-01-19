using Pizzaria.Model.Entity;
using Pizzaria.View.Enumerador;
using Pizzaria.View.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria.View.UI.ViewCidade
{
    public partial class frmGerenciarCidade : Form
    {
       
        public frmGerenciarCidade()
        {
            InitializeComponent();
        }

        private void frmGerenciarCidade_Load(object sender, EventArgs e)
        {
            PadronizarButton();

        }

        private void PadronizarButton()
        {
            Array.ForEach(GetAllButton(), c => c.Padronizar());
        }

        private Button[] GetAllButton()
                => new Button[] {btnSair,btnNovo,btnEditar,btnDeletar };
    }
}
