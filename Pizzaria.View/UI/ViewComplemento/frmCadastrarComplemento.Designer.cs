namespace Pizzaria.View.UI.ViewComplemento
{
    partial class frmCadastrarComplemento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarComplemento));
            this.gpbComplemento = new System.Windows.Forms.GroupBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnAddSabor = new System.Windows.Forms.Button();
            this.cbbSabor = new System.Windows.Forms.ComboBox();
            this.lblPrecoComplemento = new System.Windows.Forms.Label();
            this.txtPrecoComplemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDescricaoComplemento = new System.Windows.Forms.TextBox();
            this.lblSaborComplemento = new System.Windows.Forms.Label();
            this.gpbComplemento.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbComplemento
            // 
            this.gpbComplemento.Controls.Add(this.btnSalvar);
            this.gpbComplemento.Controls.Add(this.btnAddSabor);
            this.gpbComplemento.Controls.Add(this.cbbSabor);
            this.gpbComplemento.Controls.Add(this.lblPrecoComplemento);
            this.gpbComplemento.Controls.Add(this.txtPrecoComplemento);
            this.gpbComplemento.Controls.Add(this.label6);
            this.gpbComplemento.Controls.Add(this.txtDescricaoComplemento);
            this.gpbComplemento.Controls.Add(this.lblSaborComplemento);
            this.gpbComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbComplemento.Location = new System.Drawing.Point(13, 14);
            this.gpbComplemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbComplemento.Name = "gpbComplemento";
            this.gpbComplemento.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.gpbComplemento.Size = new System.Drawing.Size(458, 331);
            this.gpbComplemento.TabIndex = 27;
            this.gpbComplemento.TabStop = false;
            this.gpbComplemento.Text = "Cadastrar Complemento";
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Location = new System.Drawing.Point(26, 266);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(405, 50);
            this.btnSalvar.TabIndex = 28;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnAddSabor
            // 
            this.btnAddSabor.Location = new System.Drawing.Point(374, 43);
            this.btnAddSabor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAddSabor.Name = "btnAddSabor";
            this.btnAddSabor.Size = new System.Drawing.Size(57, 31);
            this.btnAddSabor.TabIndex = 36;
            this.btnAddSabor.Text = "+";
            this.btnAddSabor.UseVisualStyleBackColor = true;
            this.btnAddSabor.Click += new System.EventHandler(this.btnAddSabor_Click);
            // 
            // cbbSabor
            // 
            this.cbbSabor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSabor.FormattingEnabled = true;
            this.cbbSabor.Location = new System.Drawing.Point(93, 45);
            this.cbbSabor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbbSabor.Name = "cbbSabor";
            this.cbbSabor.Size = new System.Drawing.Size(273, 28);
            this.cbbSabor.TabIndex = 35;
            // 
            // lblPrecoComplemento
            // 
            this.lblPrecoComplemento.Location = new System.Drawing.Point(6, 91);
            this.lblPrecoComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPrecoComplemento.Name = "lblPrecoComplemento";
            this.lblPrecoComplemento.Size = new System.Drawing.Size(86, 32);
            this.lblPrecoComplemento.TabIndex = 34;
            this.lblPrecoComplemento.Text = "Preço";
            this.lblPrecoComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrecoComplemento
            // 
            this.txtPrecoComplemento.BackColor = System.Drawing.Color.Yellow;
            this.txtPrecoComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPrecoComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrecoComplemento.Location = new System.Drawing.Point(93, 92);
            this.txtPrecoComplemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrecoComplemento.MaxLength = 5;
            this.txtPrecoComplemento.Name = "txtPrecoComplemento";
            this.txtPrecoComplemento.Size = new System.Drawing.Size(338, 31);
            this.txtPrecoComplemento.TabIndex = 0;
            this.txtPrecoComplemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPrecoComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrecoComplemento_KeyPress);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(22, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 31);
            this.label6.TabIndex = 32;
            this.label6.Text = "Descrição";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDescricaoComplemento
            // 
            this.txtDescricaoComplemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtDescricaoComplemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescricaoComplemento.Location = new System.Drawing.Point(26, 164);
            this.txtDescricaoComplemento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtDescricaoComplemento.MaxLength = 100;
            this.txtDescricaoComplemento.Multiline = true;
            this.txtDescricaoComplemento.Name = "txtDescricaoComplemento";
            this.txtDescricaoComplemento.Size = new System.Drawing.Size(405, 92);
            this.txtDescricaoComplemento.TabIndex = 1;
            this.txtDescricaoComplemento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDescricaoComplemento.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDescricaoComplemento_KeyPress);
            // 
            // lblSaborComplemento
            // 
            this.lblSaborComplemento.Location = new System.Drawing.Point(6, 43);
            this.lblSaborComplemento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaborComplemento.Name = "lblSaborComplemento";
            this.lblSaborComplemento.Size = new System.Drawing.Size(86, 33);
            this.lblSaborComplemento.TabIndex = 29;
            this.lblSaborComplemento.Text = "Sabor";
            this.lblSaborComplemento.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmCadastrarComplemento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(483, 361);
            this.Controls.Add(this.gpbComplemento);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarComplemento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Complemento";
            this.Load += new System.EventHandler(this.frmCadastrarComplemento_Load);
            this.gpbComplemento.ResumeLayout(false);
            this.gpbComplemento.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox gpbComplemento;
        private System.Windows.Forms.Label lblPrecoComplemento;
        private System.Windows.Forms.TextBox txtPrecoComplemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDescricaoComplemento;
        private System.Windows.Forms.Label lblSaborComplemento;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnAddSabor;
        private System.Windows.Forms.ComboBox cbbSabor;
    }
}