namespace Pizzaria.View.UI.ViewLogradouro
{
    partial class frmCadastrarLogradouro
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
            this.btnCadastrarCidade = new System.Windows.Forms.Button();
            this.lblNomeLogradouro = new System.Windows.Forms.Label();
            this.txtNomeLogradouro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrarCidade
            // 
            this.btnCadastrarCidade.Location = new System.Drawing.Point(61, 122);
            this.btnCadastrarCidade.Name = "btnCadastrarCidade";
            this.btnCadastrarCidade.Size = new System.Drawing.Size(205, 62);
            this.btnCadastrarCidade.TabIndex = 5;
            this.btnCadastrarCidade.Text = "Cidade";
            this.btnCadastrarCidade.UseVisualStyleBackColor = true;
            this.btnCadastrarCidade.Click += new System.EventHandler(this.btnCadastrarCidade_Click);
            // 
            // lblNomeLogradouro
            // 
            this.lblNomeLogradouro.AutoSize = true;
            this.lblNomeLogradouro.Location = new System.Drawing.Point(18, 78);
            this.lblNomeLogradouro.Name = "lblNomeLogradouro";
            this.lblNomeLogradouro.Size = new System.Drawing.Size(35, 13);
            this.lblNomeLogradouro.TabIndex = 4;
            this.lblNomeLogradouro.Text = "Nome";
            // 
            // txtNomeLogradouro
            // 
            this.txtNomeLogradouro.Location = new System.Drawing.Point(79, 78);
            this.txtNomeLogradouro.Name = "txtNomeLogradouro";
            this.txtNomeLogradouro.Size = new System.Drawing.Size(187, 20);
            this.txtNomeLogradouro.TabIndex = 3;
            // 
            // frmCadastrarLogradouro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCadastrarCidade);
            this.Controls.Add(this.lblNomeLogradouro);
            this.Controls.Add(this.txtNomeLogradouro);
            this.Name = "frmCadastrarLogradouro";
            this.Text = "frmCadastrarLogradouro";
            this.Load += new System.EventHandler(this.frmCadastrarLogradouro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarCidade;
        private System.Windows.Forms.Label lblNomeLogradouro;
        private System.Windows.Forms.TextBox txtNomeLogradouro;
    }
}