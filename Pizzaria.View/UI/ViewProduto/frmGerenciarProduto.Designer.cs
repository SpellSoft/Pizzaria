namespace Pizzaria.View.UI.ViewProduto
{
    partial class frmGerenciarProduto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarProduto));
            this.gpbGerenciarProduto = new System.Windows.Forms.GroupBox();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbPesquisarCliente = new System.Windows.Forms.GroupBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.dgvPesquisarProduto = new System.Windows.Forms.DataGridView();
            this.gpbGerenciarProduto.SuspendLayout();
            this.gpbPesquisarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisarProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGerenciarProduto
            // 
            this.gpbGerenciarProduto.Controls.Add(this.gpbPesquisarCliente);
            this.gpbGerenciarProduto.Controls.Add(this.btnSair);
            this.gpbGerenciarProduto.Controls.Add(this.btnDeletar);
            this.gpbGerenciarProduto.Controls.Add(this.btnEditar);
            this.gpbGerenciarProduto.Controls.Add(this.btnNovo);
            this.gpbGerenciarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGerenciarProduto.Location = new System.Drawing.Point(12, 13);
            this.gpbGerenciarProduto.Name = "gpbGerenciarProduto";
            this.gpbGerenciarProduto.Size = new System.Drawing.Size(605, 273);
            this.gpbGerenciarProduto.TabIndex = 1;
            this.gpbGerenciarProduto.TabStop = false;
            this.gpbGerenciarProduto.Text = "Gerenciar Produto";
            // 
            // btnNovo
            // 
            this.btnNovo.Location = new System.Drawing.Point(24, 35);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(97, 47);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.Text = "Novo";
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(147, 35);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(97, 47);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeletar
            // 
            this.btnDeletar.Location = new System.Drawing.Point(320, 35);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(97, 47);
            this.btnDeletar.TabIndex = 0;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(499, 35);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(97, 47);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            // 
            // gpbPesquisarCliente
            // 
            this.gpbPesquisarCliente.Controls.Add(this.dgvPesquisarProduto);
            this.gpbPesquisarCliente.Controls.Add(this.txtNome);
            this.gpbPesquisarCliente.Location = new System.Drawing.Point(6, 88);
            this.gpbPesquisarCliente.Name = "gpbPesquisarCliente";
            this.gpbPesquisarCliente.Size = new System.Drawing.Size(590, 179);
            this.gpbPesquisarCliente.TabIndex = 1;
            this.gpbPesquisarCliente.TabStop = false;
            this.gpbPesquisarCliente.Text = "Pesquisar";
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNome.Location = new System.Drawing.Point(39, 33);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(476, 26);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dgvPesquisarProduto
            // 
            this.dgvPesquisarProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisarProduto.Location = new System.Drawing.Point(0, 65);
            this.dgvPesquisarProduto.Name = "dgvPesquisarProduto";
            this.dgvPesquisarProduto.Size = new System.Drawing.Size(590, 114);
            this.dgvPesquisarProduto.TabIndex = 1;
            this.dgvPesquisarProduto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvPesquisarProduto_CellFormatting);
            // 
            // frmGerenciarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 298);
            this.Controls.Add(this.gpbGerenciarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frmGerenciarProduto_Load);
            this.gpbGerenciarProduto.ResumeLayout(false);
            this.gpbPesquisarCliente.ResumeLayout(false);
            this.gpbPesquisarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisarProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGerenciarProduto;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox gpbPesquisarCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.DataGridView dgvPesquisarProduto;
    }
}