namespace Pizzaria.View.UI.ViewCidade
{
    partial class frmCadastrarCidade
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
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.lblNomeCidade = new System.Windows.Forms.Label();
            this.btnCadastrarCidade = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.Location = new System.Drawing.Point(114, 52);
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(187, 20);
            this.txtNomeCidade.TabIndex = 0;
            // 
            // lblNomeCidade
            // 
            this.lblNomeCidade.AutoSize = true;
            this.lblNomeCidade.Location = new System.Drawing.Point(53, 52);
            this.lblNomeCidade.Name = "lblNomeCidade";
            this.lblNomeCidade.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCidade.TabIndex = 1;
            this.lblNomeCidade.Text = "Nome";
            // 
            // btnCadastrarCidade
            // 
            this.btnCadastrarCidade.Location = new System.Drawing.Point(96, 96);
            this.btnCadastrarCidade.Name = "btnCadastrarCidade";
            this.btnCadastrarCidade.Size = new System.Drawing.Size(205, 62);
            this.btnCadastrarCidade.TabIndex = 2;
            this.btnCadastrarCidade.Text = "Cidade";
            this.btnCadastrarCidade.UseVisualStyleBackColor = true;
            this.btnCadastrarCidade.Click += new System.EventHandler(this.btnCadastrarCidade_Click);
            // 
            // frmCadastrarCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 262);
            this.Controls.Add(this.btnCadastrarCidade);
            this.Controls.Add(this.lblNomeCidade);
            this.Controls.Add(this.txtNomeCidade);
            this.Name = "frmCadastrarCidade";
            this.Text = "frmCadastrarCidade";
            this.Load += new System.EventHandler(this.frmCadastrarCidade_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNomeCidade;
        private System.Windows.Forms.Label lblNomeCidade;
        private System.Windows.Forms.Button btnCadastrarCidade;
    }
}