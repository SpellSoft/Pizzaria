using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.UI.ViewProduto;
using Pizzaria.View.UI.ViewEspera;
using Pizzaria.View.UI.ViewCliente;
using Pizzaria.View.UI.ViewBairro;
using Pizzaria.View.UI.ViewCidade;

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

        private void btnGerenciarClientes_Click(object sender, EventArgs e)
        {
            InsControlsForTask();
            espere.Start(RunMessage);
            OpenMdiForm.LoadNewKeepAnother(this, new frmGerenciarCliente());
            CancelarTask();
        }

        private void btnPesquisarClientes_Click(object sender, EventArgs e)
        {
            InsControlsForTask();
            espere.Start(RunMessage);
            OpenMdiForm.LoadNewKeepAnother(this, new frmPesquisarCliente());
            CancelarTask();
        }

        private void btnGerenciarBairro_Click(object sender, EventArgs e)
        {
            InsControlsForTask();
            espere.Start(RunMessage);
            OpenMdiForm.LoadNewKeepAnother(this, new frmGerenciarBairro());
            CancelarTask();
        }

        private void btnGerenciarCidade_Click(object sender, EventArgs e)
        {
            InsControlsForTask();
            espere.Start(RunMessage);
            OpenMdiForm.LoadNewKeepAnother(this, new frmGerenciarCidade());
            CancelarTask();
        }
    }
}
