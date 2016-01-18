namespace Pizzaria.View.UI.ViewBairro
{
    partial class frmGerenciarBairro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarBairro));
            this.gpbGerenciarBairro = new System.Windows.Forms.GroupBox();
            this.gpbPesquisarBairro = new System.Windows.Forms.GroupBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvBairro = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnDeletar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.gpbGerenciarBairro.SuspendLayout();
            this.gpbPesquisarBairro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBairro)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbGerenciarBairro
            // 
            this.gpbGerenciarBairro.Controls.Add(this.gpbPesquisarBairro);
            this.gpbGerenciarBairro.Controls.Add(this.btnSair);
            this.gpbGerenciarBairro.Controls.Add(this.btnDeletar);
            this.gpbGerenciarBairro.Controls.Add(this.btnEditar);
            this.gpbGerenciarBairro.Controls.Add(this.btnNovo);
            this.gpbGerenciarBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbGerenciarBairro.Location = new System.Drawing.Point(13, 13);
            this.gpbGerenciarBairro.Name = "gpbGerenciarBairro";
            this.gpbGerenciarBairro.Size = new System.Drawing.Size(425, 274);
            this.gpbGerenciarBairro.TabIndex = 0;
            this.gpbGerenciarBairro.TabStop = false;
            this.gpbGerenciarBairro.Text = "Gerenciar Bairro";
            // 
            // gpbPesquisarBairro
            // 
            this.gpbPesquisarBairro.Controls.Add(this.txtPesquisa);
            this.gpbPesquisarBairro.Controls.Add(this.dgvBairro);
            this.gpbPesquisarBairro.Location = new System.Drawing.Point(6, 78);
            this.gpbPesquisarBairro.Name = "gpbPesquisarBairro";
            this.gpbPesquisarBairro.Size = new System.Drawing.Size(411, 190);
            this.gpbPesquisarBairro.TabIndex = 5;
            this.gpbPesquisarBairro.TabStop = false;
            this.gpbPesquisarBairro.Text = "Pesquisar Bairro";
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(24, 26);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(370, 26);
            this.txtPesquisa.TabIndex = 1;
            // 
            // dgvBairro
            // 
            this.dgvBairro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBairro.Location = new System.Drawing.Point(0, 65);
            this.dgvBairro.Name = "dgvBairro";
            this.dgvBairro.Size = new System.Drawing.Size(411, 125);
            this.dgvBairro.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(337, 25);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(80, 47);
            this.btnSair.TabIndex = 1;
            this.btnSair.TabStop = false;
            this.btnSair.Text = "Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnDeletar
            // 
            this.btnDeletar.Image = ((System.Drawing.Image)(resources.GetObject("btnDeletar.Image")));
            this.btnDeletar.Location = new System.Drawing.Point(218, 25);
            this.btnDeletar.Name = "btnDeletar";
            this.btnDeletar.Size = new System.Drawing.Size(102, 47);
            this.btnDeletar.TabIndex = 2;
            this.btnDeletar.TabStop = false;
            this.btnDeletar.Text = "Deletar";
            this.btnDeletar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeletar.UseVisualStyleBackColor = true;
            this.btnDeletar.Click += new System.EventHandler(this.btnDeletar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.Image")));
            this.btnEditar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditar.Location = new System.Drawing.Point(107, 25);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 47);
            this.btnEditar.TabIndex = 3;
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
            this.btnNovo.Location = new System.Drawing.Point(6, 25);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(85, 47);
            this.btnNovo.TabIndex = 4;
            this.btnNovo.TabStop = false;
            this.btnNovo.Text = "Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            this.btnNovo.Click += new System.EventHandler(this.btnNovo_Click);
            // 
            // frmGerenciarBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(448, 299);
            this.Controls.Add(this.gpbGerenciarBairro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmGerenciarBairro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bairro";
            this.Load += new System.EventHandler(this.frmGerenciarBairro_Load);
            this.gpbGerenciarBairro.ResumeLayout(false);
            this.gpbPesquisarBairro.ResumeLayout(false);
            this.gpbPesquisarBairro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBairro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbGerenciarBairro;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnDeletar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.GroupBox gpbPesquisarBairro;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvBairro;
    }
}