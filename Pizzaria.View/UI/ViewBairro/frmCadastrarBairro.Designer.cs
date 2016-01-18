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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarBairro));
            this.btnCadastrarBairro = new System.Windows.Forms.Button();
            this.lblNomeBairro = new System.Windows.Forms.Label();
            this.txtNomeBairro = new System.Windows.Forms.TextBox();
            this.gpbCadastrarBairro = new System.Windows.Forms.GroupBox();
            this.gpbCadastrarBairro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarBairro
            // 
            this.btnCadastrarBairro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCadastrarBairro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarBairro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarBairro.Image")));
            this.btnCadastrarBairro.Location = new System.Drawing.Point(12, 111);
            this.btnCadastrarBairro.Name = "btnCadastrarBairro";
            this.btnCadastrarBairro.Size = new System.Drawing.Size(313, 62);
            this.btnCadastrarBairro.TabIndex = 5;
            this.btnCadastrarBairro.Text = "Salvar";
            this.btnCadastrarBairro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarBairro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarBairro.UseVisualStyleBackColor = true;
            this.btnCadastrarBairro.Click += new System.EventHandler(this.btnCadastrarBairro_Click);
            // 
            // lblNomeBairro
            // 
            this.lblNomeBairro.AutoSize = true;
            this.lblNomeBairro.Location = new System.Drawing.Point(6, 46);
            this.lblNomeBairro.Name = "lblNomeBairro";
            this.lblNomeBairro.Size = new System.Drawing.Size(51, 20);
            this.lblNomeBairro.TabIndex = 4;
            this.lblNomeBairro.Text = "Nome";
            // 
            // txtNomeBairro
            // 
            this.txtNomeBairro.BackColor = System.Drawing.Color.Yellow;
            this.txtNomeBairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNomeBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomeBairro.Location = new System.Drawing.Point(63, 43);
            this.txtNomeBairro.MaxLength = 50;
            this.txtNomeBairro.Name = "txtNomeBairro";
            this.txtNomeBairro.Size = new System.Drawing.Size(244, 26);
            this.txtNomeBairro.TabIndex = 3;
            this.txtNomeBairro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeBairro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeBairro_KeyPress);
            // 
            // gpbCadastrarBairro
            // 
            this.gpbCadastrarBairro.Controls.Add(this.txtNomeBairro);
            this.gpbCadastrarBairro.Controls.Add(this.lblNomeBairro);
            this.gpbCadastrarBairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastrarBairro.Location = new System.Drawing.Point(12, 5);
            this.gpbCadastrarBairro.Name = "gpbCadastrarBairro";
            this.gpbCadastrarBairro.Size = new System.Drawing.Size(313, 100);
            this.gpbCadastrarBairro.TabIndex = 6;
            this.gpbCadastrarBairro.TabStop = false;
            this.gpbCadastrarBairro.Text = "Cadastrar Bairro";
            // 
            // frmCadastrarBairro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(337, 182);
            this.Controls.Add(this.gpbCadastrarBairro);
            this.Controls.Add(this.btnCadastrarBairro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarBairro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bairro";
            this.Load += new System.EventHandler(this.frmCadastrarBairro_Load);
            this.gpbCadastrarBairro.ResumeLayout(false);
            this.gpbCadastrarBairro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarBairro;
        private System.Windows.Forms.Label lblNomeBairro;
        private System.Windows.Forms.TextBox txtNomeBairro;
        private System.Windows.Forms.GroupBox gpbCadastrarBairro;
    }
}