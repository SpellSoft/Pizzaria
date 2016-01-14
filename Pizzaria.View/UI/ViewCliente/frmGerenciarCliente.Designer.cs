namespace Pizzaria.View.UI.ViewCliente
{
    partial class frmGerenciarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarCliente));
            this.gpbGerenciarCliente = new System.Windows.Forms.GroupBox();
            this.gpbPesquisarCliente = new System.Windows.Forms.GroupBox();
            this.dgvPesquisarCliente = new System.Windows.Forms.DataGridView();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbGerenciarCliente.SuspendLayout();
            this.gpbPesquisarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisarCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGerenciarCliente
            // 
            this.gpbGerenciarCliente.Controls.Add(this.gpbPesquisarCliente);
            this.gpbGerenciarCliente.Controls.Add(this.btnSair);
            this.gpbGerenciarCliente.Controls.Add(this.btnDeletar);
            this.gpbGerenciarCliente.Controls.Add(this.btnEditar);
            this.gpbGerenciarCliente.Controls.Add(this.btnNovo);
            this.gpbGerenciarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGerenciarCliente.Location = new System.Drawing.Point(16, 5);
            this.gpbGerenciarCliente.Name = "gpbGerenciarCliente";
            this.gpbGerenciarCliente.Size = new System.Drawing.Size(605, 374);
            this.gpbGerenciarCliente.TabIndex = 2;
            this.gpbGerenciarCliente.TabStop = false;
            this.gpbGerenciarCliente.Text = "Gerenciar Cliente";
            // 
            // gpbPesquisarCliente
            // 
            this.gpbPesquisarCliente.Controls.Add(this.dgvPesquisarCliente);
            this.gpbPesquisarCliente.Controls.Add(this.txtNome);
            this.gpbPesquisarCliente.Location = new System.Drawing.Point(6, 88);
            this.gpbPesquisarCliente.Name = "gpbPesquisarCliente";
            this.gpbPesquisarCliente.Size = new System.Drawing.Size(590, 278);
            this.gpbPesquisarCliente.TabIndex = 1;
            this.gpbPesquisarCliente.TabStop = false;
            this.gpbPesquisarCliente.Text = "Pesquisar por Nome";
            // 
            // dgvPesquisarCliente
            // 
            this.dgvPesquisarCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPesquisarCliente.Location = new System.Drawing.Point(0, 59);
            this.dgvPesquisarCliente.Name = "dgvPesquisarCliente";
            this.dgvPesquisarCliente.Size = new System.Drawing.Size(590, 219);
            this.dgvPesquisarCliente.TabIndex = 1;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(6, 24);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(578, 29);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.TextChanged += new System.EventHandler(this.txtNome_TextChanged);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(482, 35);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(102, 47);
            this.btnSair.TabIndex = 0;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.Location = new System.Drawing.Point(315, 35);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(102, 47);
            this.btnDeletar.TabIndex = 0;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(147, 35);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(102, 47);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.TabStop = false;
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnNovo
            // 
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNovo.Location = new System.Drawing.Point(24, 35);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(102, 47);
            this.btnNovo.TabIndex = 0;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmGerenciarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(636, 384);
            this.Controls.Add(this.gpbGerenciarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmGerenciarCliente_Load);
            this.gpbGerenciarCliente.ResumeLayout(false);
            this.gpbPesquisarCliente.ResumeLayout(false);
            this.gpbPesquisarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPesquisarCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGerenciarCliente;
        private System.Windows.Forms.GroupBox gpbPesquisarCliente;
        private System.Windows.Forms.DataGridView dgvPesquisarCliente;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
    }
}