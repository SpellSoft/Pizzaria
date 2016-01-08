using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.UI.ViewProduto;
using Pizzaria.View.UI.ViewEspera;

namespace Pizzaria.View.UI.ViewMenu
{
    public partial class frmMenu : Form
    {
        private frmAguarde aguarde;
        private Espere espere;

        public frmMenu()
        {
            InitializeComponent();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {          

            
        }

        private void btnGerenciarProduto_Click(object sender, EventArgs e)
        {
            InsControlsForTask();
            espere.Start(RunMessage);
            OpenMdiForm.LoadNewKeepAnother(this, new frmGerenciarProduto());
            CancelarTask();
        }

        private void InsControlsForTask()
        {
            espere = new Espere();
            aguarde = new frmAguarde();
        }

        private void CancelarTask()
        {
            espere.CancelarTask();
            if (espere.Cancel.IsCancellationRequested)
            {
                aguarde?.Close();
            }
        }

        private void RunMessage()
        {
            aguarde.ShowDialog();
        }

        private void btnPesquisarProduto_Click(object sender, EventArgs e)
        {
            InsControlsForTask();
            espere.Start(RunMessage);
            OpenMdiForm.LoadNewKeepAnother(this, new frmPesquisarProduto());
            CancelarTask();
        }
    }
}
