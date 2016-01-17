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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarLogradouro));
            this.btnCadastrarLogradouro = new System.Windows.Forms.Button();
            this.lblNomeLogradouro = new System.Windows.Forms.Label();
            this.txtNomeLogradouro = new System.Windows.Forms.TextBox();
            this.gpbCadastrpLogradouro = new System.Windows.Forms.GroupBox();
            this.gpbCadastrpLogradouro.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCadastrarLogradouro
            // 
            this.btnCadastrarLogradouro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCadastrarLogradouro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarLogradouro.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarLogradouro.Image")));
            this.btnCadastrarLogradouro.Location = new System.Drawing.Point(12, 101);
            this.btnCadastrarLogradouro.Name = "btnCadastrarLogradouro";
            this.btnCadastrarLogradouro.Size = new System.Drawing.Size(292, 62);
            this.btnCadastrarLogradouro.TabIndex = 5;
            this.btnCadastrarLogradouro.Text = "Salvar";
            this.btnCadastrarLogradouro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarLogradouro.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarLogradouro.UseVisualStyleBackColor = true;
            this.btnCadastrarLogradouro.Click += new System.EventHandler(this.btnCadastrarCidade_Click);
            // 
            // lblNomeLogradouro
            // 
            this.lblNomeLogradouro.AutoSize = true;
            this.lblNomeLogradouro.Location = new System.Drawing.Point(6, 39);
            this.lblNomeLogradouro.Name = "lblNomeLogradouro";
            this.lblNomeLogradouro.Size = new System.Drawing.Size(51, 20);
            this.lblNomeLogradouro.TabIndex = 4;
            this.lblNomeLogradouro.Text = "Nome";
            // 
            // txtNomeLogradouro
            // 
            this.txtNomeLogradouro.BackColor = System.Drawing.Color.Yellow;
            this.txtNomeLogradouro.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNomeLogradouro.Location = new System.Drawing.Point(63, 36);
            this.txtNomeLogradouro.MaxLength = 50;
            this.txtNomeLogradouro.Name = "txtNomeLogradouro";
            this.txtNomeLogradouro.Size = new System.Drawing.Size(229, 26);
            this.txtNomeLogradouro.TabIndex = 3;
            this.txtNomeLogradouro.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeLogradouro.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeLogradouro_KeyPress);
            // 
            // gpbCadastrpLogradouro
            // 
            this.gpbCadastrpLogradouro.Controls.Add(this.txtNomeLogradouro);
            this.gpbCadastrpLogradouro.Controls.Add(this.lblNomeLogradouro);
            this.gpbCadastrpLogradouro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastrpLogradouro.Location = new System.Drawing.Point(12, 12);
            this.gpbCadastrpLogradouro.Name = "gpbCadastrpLogradouro";
            this.gpbCadastrpLogradouro.Size = new System.Drawing.Size(298, 83);
            this.gpbCadastrpLogradouro.TabIndex = 6;
            this.gpbCadastrpLogradouro.TabStop = false;
            this.gpbCadastrpLogradouro.Text = "Cadastrar Logradouro";
            // 
            // frmCadastrarLogradouro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(320, 176);
            this.Controls.Add(this.gpbCadastrpLogradouro);
            this.Controls.Add(this.btnCadastrarLogradouro);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarLogradouro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logradouro";
            this.Load += new System.EventHandler(this.frmCadastrarLogradouro_Load);
            this.gpbCadastrpLogradouro.ResumeLayout(false);
            this.gpbCadastrpLogradouro.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCadastrarLogradouro;
        private System.Windows.Forms.Label lblNomeLogradouro;
        private System.Windows.Forms.TextBox txtNomeLogradouro;
        private System.Windows.Forms.GroupBox gpbCadastrpLogradouro;
    }
}