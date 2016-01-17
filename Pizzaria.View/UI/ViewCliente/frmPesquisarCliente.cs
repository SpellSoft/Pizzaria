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
            FocarNoTxt(txtPesquisa);
        }
        private void ckbTelefone_CheckedChanged(object sender, EventArgs e)
        {
            ChecarCkb(sender);
            FocarNoTxt(txtPesquisa);
        }

        private void FocarNoTxt(TextBox txt)
                => this.FocoNoTxt(txt);
        private void ckbCidade_CheckedChanged(object sender, EventArgs e)
        {
            ChecarCkb(sender);
            FocarNoTxt(txtPesquisa);
        }
        private void ChecarCkb(object sender)
        {
            foreach (CheckBox ckb in GetAllCheckBox().Where(c => c != (sender as CheckBox)))
            {
                if (GetAllCheckBox().Where(c => c.Checked == true).Count() > 1)
                    ckb.Checked = false;
            }
        }

        private CheckBox[] GetAllCheckBox()
                => new CheckBox[] { ckbCidade, ckbNome, ckbTelefone };

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
        private CheckBox GetCheckBoxSelecionado()
        {
            return GetAllCheckBox().FirstOrDefault(c => c.Checked == true);
        }
        private void txtPesquisa_TextChanged(object sender, EventArgs e)
        {
            CheckBox ckb = GetCheckBoxSelecionado();
            InsClienteRep();
            if (SeExisteClienteNoBanco())
            {
                switch (ckb?.Name)
                {
                    case nameof(ckbNome):
                        PesquisarPorNome();
                        break;
                    case nameof(ckbTelefone):
                        PesquisarPorTelefone();
                        break;
                    case nameof(ckbCidade):
                        PesquisarPorCidade();
                        break;
                }
            }

        }

        private void PesquisarPorCidade()
        {
            dgvCliente.DataSource = _clienteRepositorio.PesquisaPorCidade(GetTextPesquisa());
        }

        private void PesquisarPorTelefone()
        {
            dgvCliente.DataSource = _clienteRepositorio.PesquisaPorTelefone(GetTextPesquisa());
        }

        private void PesquisarPorNome()
        {
            dgvCliente.DataSource = _clienteRepositorio.PesquisaPorNome(GetTextPesquisa());
        }

        private string GetTextPesquisa()
        {
            return txtPesquisa.Text.Trim();
        }

        private bool SeExisteClienteNoBanco()
        {
            return _clienteRepositorio.GetQuantidade() > 0;
        }
    }
}
