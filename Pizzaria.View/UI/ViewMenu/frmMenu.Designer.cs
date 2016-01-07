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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.menu = new System.Windows.Forms.MenuStrip();
            this.menuProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGerenciarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.btnPesquisarProduto = new System.Windows.Forms.ToolStripMenuItem();
            this.menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // menu
            // 
            this.menu.AutoSize = false;
            this.menu.BackColor = System.Drawing.Color.Yellow;
            this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuProduto});
            this.menu.Location = new System.Drawing.Point(0, 0);
            this.menu.Name = "menu";
            this.menu.Size = new System.Drawing.Size(742, 50);
            this.menu.TabIndex = 1;
            this.menu.Text = "menuStrip1";
            // 
            // menuProduto
            // 
            this.menuProduto.AutoSize = false;
            this.menuProduto.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnGerenciarProduto,
            this.btnPesquisarProduto});
            this.menuProduto.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuProduto.Image = ((System.Drawing.Image)(resources.GetObject("menuProduto.Image")));
            this.menuProduto.Name = "menuProduto";
            this.menuProduto.Size = new System.Drawing.Size(94, 47);
            this.menuProduto.Text = "Produto";
            // 
            // btnGerenciarProduto
            // 
            this.btnGerenciarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnGerenciarProduto.Image")));
            this.btnGerenciarProduto.Name = "btnGerenciarProduto";
            this.btnGerenciarProduto.Size = new System.Drawing.Size(153, 26);
            this.btnGerenciarProduto.Text = "Gerenciar";
            this.btnGerenciarProduto.Click += new System.EventHandler(this.btnGerenciarProduto_Click);
            // 
            // btnPesquisarProduto
            // 
            this.btnPesquisarProduto.Image = ((System.Drawing.Image)(resources.GetObject("btnPesquisarProduto.Image")));
            this.btnPesquisarProduto.Name = "btnPesquisarProduto";
            this.btnPesquisarProduto.Size = new System.Drawing.Size(153, 26);
            this.btnPesquisarProduto.Text = "Pesquisar";
            this.btnPesquisarProduto.Click += new System.EventHandler(this.btnPesquisarProduto_Click);
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(742, 461);
            this.Controls.Add(this.menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menu;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.menu.ResumeLayout(false);
            this.menu.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menu;
        private System.Windows.Forms.ToolStripMenuItem menuProduto;
        private System.Windows.Forms.ToolStripMenuItem btnGerenciarProduto;
        private System.Windows.Forms.ToolStripMenuItem btnPesquisarProduto;
    }
}