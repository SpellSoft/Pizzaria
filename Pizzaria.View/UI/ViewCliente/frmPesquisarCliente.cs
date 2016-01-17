using Pizzaria.Controller.Repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Mike.Utilities.Desktop;
using Pizzaria.Model.ModelView;

namespace Pizzaria.View.UI.ViewCliente
{
    public partial class frmPesquisarCliente : Form
    {
        private ClienteRepositorio _clienteRepositorio;
        private ClienteRepositorio InsClienteRep()
                => _clienteRepositorio = new ClienteRepositorio();

        public frmPesquisarCliente()
        {
            InitializeComponent();
        }
        private void ckbNome_CheckedChanged(object sender, EventArgs e)
        {
            ChecarCkb(sender);
        }
        private void ckbTelefone_CheckedChanged(object sender, EventArgs e)
        {
            ChecarCkb(sender);
        }
        private void ckbBairro_CheckedChanged(object sender, EventArgs e)
        {
            ChecarCkb(sender);
        }
        private void ChecarCkb(object sender)
        {
            foreach (CheckBox ckb in GetAllCheckBox().Where(c => c != (sender as CheckBox)))
            {
                if (GetAllCheckBox().Where(c => c.Checked == true).Count() > 1)
                {
                    ckb.Checked = false;
                }
            }
        }

        private CheckBox[] GetAllCheckBox()
                => new CheckBox[] { ckbBairro, ckbNome, ckbTelefone };

        private void frmPesquisarCliente_Load(object sender, EventArgs e)
        {
            InsClienteRep();
            CarregarGrid();
        }

        private void CarregarGrid()
        {
            dgvCliente.DataSource = _clienteRepositorio.PesquisaPorNome();
            EscondirLinhaDoGrid();
            PadronizarGrid();
            AjustarTamanhoDoGrid();
        }

        private void AjustarTamanhoDoGrid()
        {            
            dgvCliente.AjustartamanhoDoDataGridView
            (
               new List<TamanhoGrid>
               {
                   new TamanhoGrid {ColunaNome = nameof(ClientePesquisaViewModel.Nome), Tamanho=290 },
                   new TamanhoGrid {ColunaNome = nameof(ClientePesquisaViewModel.Cidade), Tamanho = 150  },
                   new TamanhoGrid {ColunaNome = nameof(ClientePesquisaViewModel.Telefone), Tamanho = 150 }
               }
            );
        }

        private void EscondirLinhaDoGrid()
        {
            dgvCliente.EsconderColuna(nameof(ClientePesquisaViewModel.ClienteID));
        }

        private void PadronizarGrid()
        {
            dgvCliente.PadronizarGrid();
        }
    }
}
