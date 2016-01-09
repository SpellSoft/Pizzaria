namespace Pizzaria.View.UI.ViewProduto
{
    partial class frmPesquisarProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPesquisarProduto));
            this.gpbPesquisarProduto = new System.Windows.Forms.GroupBox();
            this.ckbNome = new System.Windows.Forms.CheckBox();
            this.ckbCategoria = new System.Windows.Forms.CheckBox();
            this.ckbCódigo = new System.Windows.Forms.CheckBox();
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dgvProduto = new System.Windows.Forms.DataGridView();
            this.gpbPesquisarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).BeginInit();
            this.SuspendLayout();
            // 
            // gpbPesquisarProduto
            // 
            this.gpbPesquisarProduto.Controls.Add(this.ckbNome);
            this.gpbPesquisarProduto.Controls.Add(this.ckbCategoria);
            this.gpbPesquisarProduto.Controls.Add(this.ckbCódigo);
            this.gpbPesquisarProduto.Controls.Add(this.txtPesquisa);
            this.gpbPesquisarProduto.Controls.Add(this.dgvProduto);
            this.gpbPesquisarProduto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbPesquisarProduto.Location = new System.Drawing.Point(12, 12);
            this.gpbPesquisarProduto.Name = "gpbPesquisarProduto";
            this.gpbPesquisarProduto.Size = new System.Drawing.Size(590, 375);
            this.gpbPesquisarProduto.TabIndex = 0;
            this.gpbPesquisarProduto.TabStop = false;
            this.gpbPesquisarProduto.Text = "Pesquisar Produto";
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
            // ckbCategoria
            // 
            this.ckbCategoria.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ckbCategoria.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbCategoria.Image = ((System.Drawing.Image)(resources.GetObject("ckbCategoria.Image")));
            this.ckbCategoria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbCategoria.Location = new System.Drawing.Point(409, 25);
            this.ckbCategoria.Name = "ckbCategoria";
            this.ckbCategoria.Size = new System.Drawing.Size(180, 67);
            this.ckbCategoria.TabIndex = 2;
            this.ckbCategoria.Text = "Categoria";
            this.ckbCategoria.UseVisualStyleBackColor = true;
            this.ckbCategoria.CheckedChanged += new System.EventHandler(this.ckbCategoria_CheckedChanged);
            // 
            // ckbCódigo
            // 
            this.ckbCódigo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.ckbCódigo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ckbCódigo.Image = ((System.Drawing.Image)(resources.GetObject("ckbCódigo.Image")));
            this.ckbCódigo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.ckbCódigo.Location = new System.Drawing.Point(209, 25);
            this.ckbCódigo.Name = "ckbCódigo";
            this.ckbCódigo.Size = new System.Drawing.Size(180, 67);
            this.ckbCódigo.TabIndex = 2;
            this.ckbCódigo.Text = "Código";
            this.ckbCódigo.UseVisualStyleBackColor = true;
            this.ckbCódigo.CheckedChanged += new System.EventHandler(this.ckbCódigo_CheckedChanged);
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
            this.txtPesquisa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPesquisa_KeyPress);
            // 
            // dgvProduto
            // 
            this.dgvProduto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduto.Location = new System.Drawing.Point(0, 135);
            this.dgvProduto.Name = "dgvProduto";
            this.dgvProduto.Size = new System.Drawing.Size(590, 240);
            this.dgvProduto.TabIndex = 0;
            this.dgvProduto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvProduto_CellFormatting);
            // 
            // frmPesquisarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 399);
            this.Controls.Add(this.gpbPesquisarProduto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPesquisarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Produto";
            this.Load += new System.EventHandler(this.frmPesquisarProduto_Load);
            this.gpbPesquisarProduto.ResumeLayout(false);
            this.gpbPesquisarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbPesquisarProduto;
        private System.Windows.Forms.DataGridView dgvProduto;
        private System.Windows.Forms.TextBox txtPesquisa;
        private System.Windows.Forms.CheckBox ckbNome;
        private System.Windows.Forms.CheckBox ckbCategoria;
        private System.Windows.Forms.CheckBox ckbCódigo;
    }
}