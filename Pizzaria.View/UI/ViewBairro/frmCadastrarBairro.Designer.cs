namespace Pizzaria.View.UI.ViewBairro
{
    partial class frmCadastrarBairro
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
            this.btnCadastrarBairro = new System.Windows.Forms.Button();
            this.lblNomeBairro = new System.Windows.Forms.Label();
            this.txtNomeBairro = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnCadastrarBairro
            // 
            this.btnCadastrarBairro.Location = new System.Drawing.Point(61, 122);
            this.btnCadastrarBairro.Name = "btnCadastrarBairro";
            this.btnCadastrarBairro.Size = new System.Drawing.Size(205, 62);
            this.btnCadastrarBairro.TabIndex = 5;
            this.btnCadastrarBairro.Text = "Bairro";
            this.btnCadastrarBairro.UseVisualStyleBackColor = true;
            this.btnCadastrarBairro.Click += new System.EventHandler(this.btnCadastrarBairro_Click);
            // 
            // lblNomeBairro
            // 
            this.lblNomeBairro.AutoSize = true;
            this.lblNomeBairro.Location = new System.Drawing.Point(18, 78);
            this.lblNomeBairro.Name = "lblNomeBairro";
            this.lblNomeBairro.Size = new System.Drawing.Size(35, 13);
            this.lblNomeBairro.TabIndex = 4;
            this.lblNomeBairro.Text = "Nome";
            // 
            // txtNomeBairro
            // 
            this.txtNomeBairro.Location = new System.Drawing.Point(79, 78);
            this.txtNomeBairro.Name = "txtNomeBairro";
            this.txtNomeBairro.Size = new System.Drawing.Size(187, 20);
            this.txtNomeBairro.TabIndex = 3;
            // 
            // frmCadastrarBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btnCadastrarBairro);
            this.Controls.Add(this.lblNomeBairro);
            this.Controls.Add(this.txtNomeBairro);
            this.Name = "frmCadastrarBairro";
            this.Text = "frmCadastrarBairro";
            this.Load += new System.EventHandler(this.frmCadastrarBairro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarBairro;
        private System.Windows.Forms.Label lblNomeBairro;
        private System.Windows.Forms.TextBox txtNomeBairro;
    }
}