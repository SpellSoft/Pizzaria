namespace Pizzaria.View.UI.ViewMenu
{
    partial class frmMenu
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerenciarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesquisarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProduto});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuProduto
            // 
            this.menuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerenciarProduto,
            this.btnPesquisarProduto});
            this.menuProduto.Name = "menuProduto";
            this.menuProduto.Size = new System.Drawing.Size(62, 20);
            this.menuProduto.Text = "Produto";
            // 
            // btnGerenciarProduto
            // 
            this.btnGerenciarProduto.Name = "btnGerenciarProduto";
            this.btnGerenciarProduto.Size = new System.Drawing.Size(152, 22);
            this.btnGerenciarProduto.Text = "Gerenciar";
            this.btnGerenciarProduto.Click += new System.EventHandler(this.btnGerenciarProduto_Click);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(152, 22);
            this.btnPesquisarProduto.Text = "Pesquisar";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 682);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuProduto;
        private System.Windows.Forms.ToolStripMenuItem btnGerenciarProduto;
        private System.Windows.Forms.ToolStripMenuItem btnPesquisarProduto;
    }
}