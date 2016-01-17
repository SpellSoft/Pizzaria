namespace Pizzaria.View.UI.ViewCliente
{
    partial class frmPesquisarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarCliente));
            this.gpbPesquisarCliente = new System.Windows.Forms.GroupBox();
            this.ckbNome = new System.Windows.Forms.CheckBox();
            this.ckbCidade = new System.Windows.Forms.CheckBox();
            this.ckbTelefone = new System.Windows.Forms.CheckBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.gpbPesquisarCliente.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPesquisarCliente
            // 
            this.gpbPesquisarCliente.Controls.Add(this.ckbNome);
            this.gpbPesquisarCliente.Controls.Add(this.ckbCidade);
            this.gpbPesquisarCliente.Controls.Add(this.ckbTelefone);
            this.gpbPesquisarCliente.Controls.Add(this.txtPesquisa);
            this.gpbPesquisarCliente.Controls.Add(this.dgvCliente);
            this.gpbPesquisarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarCliente.Location = new System.Drawing.Point(12, 12);
            this.gpbPesquisarCliente.Name = "gpbPesquisarCliente";
            this.gpbPesquisarCliente.Size = new System.Drawing.Size(590, 375);
            this.gpbPesquisarCliente.TabIndex = 1;
            this.gpbPesquisarCliente.TabStop = false;
            this.gpbPesquisarCliente.Text = "Pesquisar Cliente";
            // 
            // ckbNome
            // 
            this.ckbNome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ckbNome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbNome.Image = ((System.Drawing.Image)(resources.GetObject("ckbNome.Image")));
            this.ckbNome.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbNome.Location = new System.Drawing.Point(7, 25);
            this.ckbNome.Name = "ckbNome";
            this.ckbNome.Size = new System.Drawing.Size(180, 67);
            this.ckbNome.TabIndex = 3;
            this.ckbNome.Text = "Nome";
            this.ckbNome.UseVisualStyleBackColor = true;
            this.ckbNome.CheckedChanged += new System.EventHandler(this.ckbNome_CheckedChanged);
            // 
            // ckbCidade
            // 
            this.ckbCidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ckbCidade.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbCidade.Image = ((System.Drawing.Image)(resources.GetObject("ckbCidade.Image")));
            this.ckbCidade.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbCidade.Location = new System.Drawing.Point(409, 25);
            this.ckbCidade.Name = "ckbCidade";
            this.ckbCidade.Size = new System.Drawing.Size(180, 67);
            this.ckbCidade.TabIndex = 2;
            this.ckbCidade.Text = "Bairro";
            this.ckbCidade.UseVisualStyleBackColor = true;
            this.ckbCidade.CheckedChanged += new System.EventHandler(this.ckbCidade_CheckedChanged);
            // 
            // ckbTelefone
            // 
            this.ckbTelefone.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ckbTelefone.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbTelefone.Image = ((System.Drawing.Image)(resources.GetObject("ckbTelefone.Image")));
            this.ckbTelefone.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbTelefone.Location = new System.Drawing.Point(197, 25);
            this.ckbTelefone.Name = "ckbTelefone";
            this.ckbTelefone.Size = new System.Drawing.Size(196, 67);
            this.ckbTelefone.TabIndex = 2;
            this.ckbTelefone.Text = "Telefone";
            this.ckbTelefone.UseVisualStyleBackColor = true;
            this.ckbTelefone.CheckedChanged += new System.EventHandler(this.ckbTelefone_CheckedChanged);
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.Location = new System.Drawing.Point(7, 98);
            this.txtPesquisa.MaxLength = 20;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Size = new System.Drawing.Size(577, 29);
            this.txtPesquisa.TabIndex = 1;
            this.txtPesquisa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPesquisa.TextChanged += new System.EventHandler(this.txtPesquisa_TextChanged);
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(0, 135);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(590, 240);
            this.dgvCliente.TabIndex = 0;
            // 
            // frmPesquisarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(619, 402);
            this.Controls.Add(this.gpbPesquisarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmPesquisarCliente_Load);
            this.gpbPesquisarCliente.ResumeLayout(false);
            this.gpbPesquisarCliente.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisarCliente;
        private System.Windows.Forms.CheckBox ckbNome;
        private System.Windows.Forms.CheckBox ckbCidade;
        private System.Windows.Forms.CheckBox ckbTelefone;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.DataGridView dgvCliente;
    }
}