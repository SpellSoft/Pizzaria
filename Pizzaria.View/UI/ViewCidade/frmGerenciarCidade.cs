using Pizzaria.Controller.Repository;
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
using Mike.Utilities.Desktop;

namespace Pizzaria.View.UI.ViewCidade
{
    public partial class frmGerenciarCidade : Form
    {

        private CidadeRepositorio _cidadeRepositorio;
        private CidadeRepositorio InsCidadeRep()
        {
            return _cidadeRepositorio = new CidadeRepositorio();
        }
        public frmGerenciarCidade()
        {
            InitializeComponent();
        }

        private void frmGerenciarCidade_Load(object sender, EventArgs e)
        {
            InsCidadeRep();
            PadronizarButton();
            CarregarCidade();

        }

        private void CarregarCidade()
        {
            dgvCidade.DataSource = _cidadeRepositorio.Listar();
            PadronizarGrid();
            EsconderColuna();
        }

        private void EsconderColuna()
        {
            dgvCidade.EsconderColuna(nameof(Cidade.CidadeID));
        }

        private void PadronizarGrid()
        {
            dgvCidade.PadronizarGrid();

        }

        private void PadronizarButton()
        {
            Array.ForEach(GetAllButton(), c => c.Padronizar());
        }

        private Button[] GetAllButton()
                => new Button[] {btnSair,btnNovo,btnEditar,btnDeletar };

        private void btnSair_Click(object sender, EventArgs e)
        {
            FecharForm();
        }

        private void FecharForm()
        {
            this.Close();
        }
    }
}
