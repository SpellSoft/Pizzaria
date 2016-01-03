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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarBorda));
            this.btnSalvar = new System.Windows.Forms.Button();
            this.gpbComplemento = new System.Windows.Forms.GroupBox();
            this.lblPrecoComplemento = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtPrecoComplemento = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.txtDescricaoComplemento = new System.Windows.Forms.TextBox();
            this.lblSaborComplemento = new System.Windows.Forms.Label();
            this.gpbComplemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(26, 281);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(368, 58);
            this.btnSalvar.TabIndex = 31;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // gpbComplemento
            // 
            this.gpbComplemento.Controls.Add(this.btnSalvar);
            this.gpbComplemento.Controls.Add(this.lblPrecoComplemento);
            this.gpbComplemento.Controls.Add(this.txtNome);
            this.gpbComplemento.Controls.Add(this.txtPrecoComplemento);
            this.gpbComplemento.Controls.Add(this.lblDescricao);
            this.gpbComplemento.Controls.Add(this.txtDescricaoComplemento);
            this.gpbComplemento.Controls.Add(this.lblSaborComplemento);
            this.gpbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbComplemento.Location = new System.Drawing.Point(13, 14);
            this.gpbComplemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbComplemento.Name = "gpbComplemento";
            this.gpbComplemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbComplemento.Size = new System.Drawing.Size(411, 360);
            this.gpbComplemento.TabIndex = 30;
            this.gpbComplemento.TabStop = false;
            this.gpbComplemento.Text = "Complemento";
            // 
            // lblPrecoComplemento
            // 
            this.lblPrecoComplemento.Location = new System.Drawing.Point(8, 85);
            this.lblPrecoComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoComplemento.Name = "lblPrecoComplemento";
            this.lblPrecoComplemento.Size = new System.Drawing.Size(80, 31);
            this.lblPrecoComplemento.TabIndex = 34;
            this.lblPrecoComplemento.Text = "Preço";
            this.lblPrecoComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNome
            // 
            this.txtNome.BackColor = System.Drawing.Color.Yellow;
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(93, 40);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNome.MaxLength = 30;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(301, 31);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNome.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNome_KeyPress);
            // 
            // txtPrecoComplemento
            // 
            this.txtPrecoComplemento.BackColor = System.Drawing.Color.Yellow;
            this.txtPrecoComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPrecoComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoComplemento.Location = new System.Drawing.Point(93, 85);
            this.txtPrecoComplemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecoComplemento.MaxLength = 5;
            this.txtPrecoComplemento.Name = "txtPrecoComplemento";
            this.txtPrecoComplemento.Size = new System.Drawing.Size(301, 31);
            this.txtPrecoComplemento.TabIndex = 0;
            this.txtPrecoComplemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecoComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoComplemento_KeyPress);
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(22, 131);
            this.lblDescricao.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(80, 20);
            this.lblDescricao.TabIndex = 32;
            this.lblDescricao.Text = "Descrição";
            this.lblDescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescricaoComplemento
            // 
            this.txtDescricaoComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtDescricaoComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoComplemento.Location = new System.Drawing.Point(26, 156);
            this.txtDescricaoComplemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricaoComplemento.MaxLength = 50;
            this.txtDescricaoComplemento.Multiline = true;
            this.txtDescricaoComplemento.Name = "txtDescricaoComplemento";
            this.txtDescricaoComplemento.Size = new System.Drawing.Size(368, 115);
            this.txtDescricaoComplemento.TabIndex = 1;
            this.txtDescricaoComplemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescricaoComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricaoComplemento_KeyPress);
            // 
            // lblSaborComplemento
            // 
            this.lblSaborComplemento.Location = new System.Drawing.Point(14, 40);
            this.lblSaborComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaborComplemento.Name = "lblSaborComplemento";
            this.lblSaborComplemento.Size = new System.Drawing.Size(70, 31);
            this.lblSaborComplemento.TabIndex = 29;
            this.lblSaborComplemento.Text = "Nome";
            this.lblSaborComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadastrarBorda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(437, 388);
            this.Controls.Add(this.gpbComplemento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarBorda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Borda";
            this.gpbComplemento.ResumeLayout(false);
            this.gpbComplemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.GroupBox gpbComplemento;
        private System.Windows.Forms.Label lblPrecoComplemento;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtPrecoComplemento;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.TextBox txtDescricaoComplemento;
        private System.Windows.Forms.Label lblSaborComplemento;
    }
}