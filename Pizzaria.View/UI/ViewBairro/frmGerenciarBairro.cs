using System;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.View.Utilities;
using Pizzaria.Controller.Repository;
using Pizzaria.Model.Entity;

namespace Pizzaria.View.UI.ViewBairro
{
    public partial class frmGerenciarBairro : Form
    {
        private BairroRepositorio _bairroRepositorio;
        private BairroRepositorio InsBairroRep()
                => _bairroRepositorio = new BairroRepositorio();
        public frmGerenciarBairro()
        {
            InitializeComponent();
        }

        private void frmGerenciarBairro_Load(object sender, EventArgs e)
        {
            Array.ForEach(GetAllButton(), c => c.Padronizar());
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            InsBairroRep();
            dgvBairro.DataSource = _bairroRepositorio.Listar();
            EsconderColuna();
            pdronizarGrid();
        }

        private void pdronizarGrid()
        {
            dgvBairro.PadronizarGrid();
        }

        private void EsconderColuna()
        {
            dgvBairro.EsconderColuna(nameof(Bairro.BairroID));
        }

        private Button[] GetAllButton()
        {
            return new Button[] { btnNovo,btnSair,btnEditar,btnDeletar};
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            switch (keyData)
            {

                case Keys.F1:

                    break;
                case Keys.F2:

                    break;
                case Keys.F3:

                    break;
                case Keys.F4:

                    break;
                case Keys.F5:

                    break;
                case Keys.F6:

                    break;
                case Keys.F7:

                    break;
                case Keys.F8:

                    break;
                case Keys.F9:
                    break;
                case Keys.F10:
                    break;
                case Keys.F11:
                    break;
                case Keys.F12:

                    break;
                case Keys.Escape:

                    break;
                case Keys.Up:
                    dgvBairro.MoveToUp();
                    break;
                case Keys.Down:
                    dgvBairro.MoveToDown();
                    break;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

    }
}
