namespace Pizzaria.View.UI.ViewBorda
{
    partial class frmCadastrarBorda
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
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpbComplemento = new System.Windows.Forms.GroupBox();
            this.lblPrecoComplemento = new System.Windows.Forms.Label();
            this.txtPrecoComplemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricaoComplemento = new System.Windows.Forms.TextBox();
            this.lblSaborComplemento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbComplemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(71, 256);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(669, 38);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gpbComplemento
            // 
            this.gpbComplemento.Controls.Add(this.lblPrecoComplemento);
            this.gpbComplemento.Controls.Add(this.txtNome);
            this.gpbComplemento.Controls.Add(this.txtPrecoComplemento);
            this.gpbComplemento.Controls.Add(this.label6);
            this.gpbComplemento.Controls.Add(this.txtDescricaoComplemento);
            this.gpbComplemento.Controls.Add(this.lblSaborComplemento);
            this.gpbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbComplemento.Location = new System.Drawing.Point(56, 100);
            this.gpbComplemento.Name = "gpbComplemento";
            this.gpbComplemento.Size = new System.Drawing.Size(669, 150);
            this.gpbComplemento.TabIndex = 30;
            this.gpbComplemento.TabStop = false;
            this.gpbComplemento.Text = "Complemento";
            // 
            // lblPrecoComplemento
            // 
            this.lblPrecoComplemento.Location = new System.Drawing.Point(393, 29);
            this.lblPrecoComplemento.Name = "lblPrecoComplemento";
            this.lblPrecoComplemento.Size = new System.Drawing.Size(57, 27);
            this.lblPrecoComplemento.TabIndex = 34;
            this.lblPrecoComplemento.Text = "Preço";
            this.lblPrecoComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrecoComplemento
            // 
            this.txtPrecoComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoComplemento.Location = new System.Drawing.Point(450, 26);
            this.txtPrecoComplemento.Name = "txtPrecoComplemento";
            this.txtPrecoComplemento.Size = new System.Drawing.Size(202, 31);
            this.txtPrecoComplemento.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 20);
            this.label6.TabIndex = 32;
            this.label6.Text = "Descrição";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescricaoComplemento
            // 
            this.txtDescricaoComplemento.Location = new System.Drawing.Point(18, 82);
            this.txtDescricaoComplemento.Multiline = true;
            this.txtDescricaoComplemento.Name = "txtDescricaoComplemento";
            this.txtDescricaoComplemento.Size = new System.Drawing.Size(634, 61);
            this.txtDescricaoComplemento.TabIndex = 1;
            // 
            // lblSaborComplemento
            // 
            this.lblSaborComplemento.Location = new System.Drawing.Point(11, 28);
            this.lblSaborComplemento.Name = "lblSaborComplemento";
            this.lblSaborComplemento.Size = new System.Drawing.Size(57, 31);
            this.lblSaborComplemento.TabIndex = 29;
            this.lblSaborComplemento.Text = "Nome";
            this.lblSaborComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(189, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 25);
            this.label2.TabIndex = 29;
            this.label2.Text = "Borda";
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(100, 29);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(202, 31);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // frmCadastrarBorda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 356);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.gpbComplemento);
            this.Controls.Add(this.label2);
            this.Name = "frmCadastrarBorda";
            this.Text = "frmCadastrarBorda";
            this.gpbComplemento.ResumeLayout(false);
            this.gpbComplemento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpbComplemento;
        private System.Windows.Forms.Label lblPrecoComplemento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPrecoComplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescricaoComplemento;
        private System.Windows.Forms.Label lblSaborComplemento;
        private System.Windows.Forms.Label label2;
    }
}