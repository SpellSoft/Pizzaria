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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarCidade));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblNomeCidade = new System.Windows.Forms.Label();
            this.txtNomeCidade = new System.Windows.Forms.TextBox();
            this.btnCadastrarCidade = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblNomeCidade);
            this.groupBox1.Controls.Add(this.txtNomeCidade);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(360, 85);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastrar Cidade";
            // 
            // lblNomeCidade
            // 
            this.lblNomeCidade.AutoSize = true;
            this.lblNomeCidade.Location = new System.Drawing.Point(17, 38);
            this.lblNomeCidade.Name = "lblNomeCidade";
            this.lblNomeCidade.Size = new System.Drawing.Size(51, 20);
            this.lblNomeCidade.TabIndex = 4;
            this.lblNomeCidade.Text = "Nome";
            // 
            // txtNomeCidade
            // 
            this.txtNomeCidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNomeCidade.Location = new System.Drawing.Point(83, 35);
            this.txtNomeCidade.MaxLength = 50;
            this.txtNomeCidade.Name = "txtNomeCidade";
            this.txtNomeCidade.Size = new System.Drawing.Size(260, 26);
            this.txtNomeCidade.TabIndex = 3;
            this.txtNomeCidade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNomeCidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomeCidade_KeyPress);
            // 
            // btnCadastrarCidade
            // 
            this.btnCadastrarCidade.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCadastrarCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrarCidade.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrarCidade.Image")));
            this.btnCadastrarCidade.Location = new System.Drawing.Point(12, 103);
            this.btnCadastrarCidade.Name = "btnCadastrarCidade";
            this.btnCadastrarCidade.Size = new System.Drawing.Size(360, 62);
            this.btnCadastrarCidade.TabIndex = 5;
            this.btnCadastrarCidade.Text = "Salvar";
            this.btnCadastrarCidade.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrarCidade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrarCidade.UseVisualStyleBackColor = true;
            this.btnCadastrarCidade.Click += new System.EventHandler(this.btnCadastrarCidade_Click);
            // 
            // frmCadastrarCidade
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(383, 172);
            this.Controls.Add(this.btnCadastrarCidade);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarCidade";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cidade";
            this.Load += new System.EventHandler(this.frmCadastrarCidade_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCadastrarCidade;
        private System.Windows.Forms.Label lblNomeCidade;
        private System.Windows.Forms.TextBox txtNomeCidade;
    }
}