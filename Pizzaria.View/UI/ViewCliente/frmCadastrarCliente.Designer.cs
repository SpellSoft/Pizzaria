namespace Pizzaria.View.UI.ViewCliente
{
    partial class frmCadastrarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadastrarCliente));
            this.gpbCadastrarCliente = new System.Windows.Forms.GroupBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.lblNome = new System.Windows.Forms.Label();
            this.gpbContatos = new System.Windows.Forms.GroupBox();
            this.mtbCelular = new System.Windows.Forms.MaskedTextBox();
            this.mtbFixo = new System.Windows.Forms.MaskedTextBox();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblFixo = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.btnAdicionarLogradouro = new System.Windows.Forms.Button();
            this.lblNumero = new System.Windows.Forms.Label();
            this.btnAdicionarBairro = new System.Windows.Forms.Button();
            this.btnAdicionarCidade = new System.Windows.Forms.Button();
            this.txtPontoReferencia = new System.Windows.Forms.TextBox();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.lblRefrerencia = new System.Windows.Forms.Label();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.cbbLogradouro = new System.Windows.Forms.ComboBox();
            this.cbbBairro = new System.Windows.Forms.ComboBox();
            this.cbbCidade = new System.Windows.Forms.ComboBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.gpbCadastrarCliente.SuspendLayout();
            this.gpbContatos.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbCadastrarCliente
            // 
            this.gpbCadastrarCliente.Controls.Add(this.btnCadastrar);
            this.gpbCadastrarCliente.Controls.Add(this.lblNome);
            this.gpbCadastrarCliente.Controls.Add(this.gpbContatos);
            this.gpbCadastrarCliente.Controls.Add(this.gpbEndereco);
            this.gpbCadastrarCliente.Controls.Add(this.txtNome);
            this.gpbCadastrarCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbCadastrarCliente.Location = new System.Drawing.Point(12, 12);
            this.gpbCadastrarCliente.Name = "gpbCadastrarCliente";
            this.gpbCadastrarCliente.Size = new System.Drawing.Size(421, 564);
            this.gpbCadastrarCliente.TabIndex = 0;
            this.gpbCadastrarCliente.TabStop = false;
            this.gpbCadastrarCliente.Text = "Cadastrar Cliente";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Yellow;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(10, 513);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(403, 43);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Salvar";
            this.btnCadastrar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(17, 39);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // gpbContatos
            // 
            this.gpbContatos.Controls.Add(this.mtbCelular);
            this.gpbContatos.Controls.Add(this.mtbFixo);
            this.gpbContatos.Controls.Add(this.lblCelular);
            this.gpbContatos.Controls.Add(this.lblFixo);
            this.gpbContatos.Location = new System.Drawing.Point(6, 417);
            this.gpbContatos.Name = "gpbContatos";
            this.gpbContatos.Size = new System.Drawing.Size(409, 90);
            this.gpbContatos.TabIndex = 1;
            this.gpbContatos.TabStop = false;
            this.gpbContatos.Text = "Telefone";
            // 
            // mtbCelular
            // 
            this.mtbCelular.Location = new System.Drawing.Point(277, 37);
            this.mtbCelular.Mask = "(99) 000-0000";
            this.mtbCelular.Name = "mtbCelular";
            this.mtbCelular.Size = new System.Drawing.Size(112, 26);
            this.mtbCelular.TabIndex = 5;
            // 
            // mtbFixo
            // 
            this.mtbFixo.Location = new System.Drawing.Point(55, 37);
            this.mtbFixo.Mask = "(99) 000-0000";
            this.mtbFixo.Name = "mtbFixo";
            this.mtbFixo.Size = new System.Drawing.Size(112, 26);
            this.mtbFixo.TabIndex = 5;
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Location = new System.Drawing.Point(213, 40);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(58, 20);
            this.lblCelular.TabIndex = 4;
            this.lblCelular.Text = "Celular";
            // 
            // lblFixo
            // 
            this.lblFixo.AutoSize = true;
            this.lblFixo.Location = new System.Drawing.Point(11, 40);
            this.lblFixo.Name = "lblFixo";
            this.lblFixo.Size = new System.Drawing.Size(38, 20);
            this.lblFixo.TabIndex = 4;
            this.lblFixo.Text = "Fixo";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.btnAdicionarLogradouro);
            this.gpbEndereco.Controls.Add(this.lblNumero);
            this.gpbEndereco.Controls.Add(this.btnAdicionarBairro);
            this.gpbEndereco.Controls.Add(this.btnAdicionarCidade);
            this.gpbEndereco.Controls.Add(this.txtPontoReferencia);
            this.gpbEndereco.Controls.Add(this.txtNumero);
            this.gpbEndereco.Controls.Add(this.lblRefrerencia);
            this.gpbEndereco.Controls.Add(this.lblLogradouro);
            this.gpbEndereco.Controls.Add(this.lblBairro);
            this.gpbEndereco.Controls.Add(this.lblCidade);
            this.gpbEndereco.Controls.Add(this.cbbLogradouro);
            this.gpbEndereco.Controls.Add(this.cbbBairro);
            this.gpbEndereco.Controls.Add(this.cbbCidade);
            this.gpbEndereco.Location = new System.Drawing.Point(12, 69);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(396, 346);
            this.gpbEndereco.TabIndex = 1;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // btnAdicionarLogradouro
            // 
            this.btnAdicionarLogradouro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionarLogradouro.BackgroundImage")));
            this.btnAdicionarLogradouro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionarLogradouro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarLogradouro.Location = new System.Drawing.Point(325, 154);
            this.btnAdicionarLogradouro.Name = "btnAdicionarLogradouro";
            this.btnAdicionarLogradouro.Size = new System.Drawing.Size(58, 28);
            this.btnAdicionarLogradouro.TabIndex = 3;
            this.btnAdicionarLogradouro.UseVisualStyleBackColor = true;
            this.btnAdicionarLogradouro.Click += new System.EventHandler(this.btnAdicionarLogradouro_Click);
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(11, 208);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 20);
            this.lblNumero.TabIndex = 2;
            this.lblNumero.Text = "Número";
            // 
            // btnAdicionarBairro
            // 
            this.btnAdicionarBairro.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionarBairro.BackgroundImage")));
            this.btnAdicionarBairro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionarBairro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarBairro.Location = new System.Drawing.Point(325, 86);
            this.btnAdicionarBairro.Name = "btnAdicionarBairro";
            this.btnAdicionarBairro.Size = new System.Drawing.Size(58, 28);
            this.btnAdicionarBairro.TabIndex = 3;
            this.btnAdicionarBairro.UseVisualStyleBackColor = true;
            this.btnAdicionarBairro.Click += new System.EventHandler(this.btnAdicionarBairro_Click);
            // 
            // btnAdicionarCidade
            // 
            this.btnAdicionarCidade.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAdicionarCidade.BackgroundImage")));
            this.btnAdicionarCidade.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAdicionarCidade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionarCidade.Location = new System.Drawing.Point(325, 37);
            this.btnAdicionarCidade.Name = "btnAdicionarCidade";
            this.btnAdicionarCidade.Size = new System.Drawing.Size(58, 28);
            this.btnAdicionarCidade.TabIndex = 3;
            this.btnAdicionarCidade.UseVisualStyleBackColor = true;
            this.btnAdicionarCidade.Click += new System.EventHandler(this.btnAdicionarCidade_Click);
            // 
            // txtPontoReferencia
            // 
            this.txtPontoReferencia.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtPontoReferencia.Location = new System.Drawing.Point(13, 273);
            this.txtPontoReferencia.MaxLength = 100;
            this.txtPontoReferencia.Multiline = true;
            this.txtPontoReferencia.Name = "txtPontoReferencia";
            this.txtPontoReferencia.Size = new System.Drawing.Size(370, 64);
            this.txtPontoReferencia.TabIndex = 0;
            this.txtPontoReferencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtNumero
            // 
            this.txtNumero.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNumero.Location = new System.Drawing.Point(82, 206);
            this.txtNumero.MaxLength = 10;
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(301, 26);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblRefrerencia
            // 
            this.lblRefrerencia.AutoSize = true;
            this.lblRefrerencia.Location = new System.Drawing.Point(11, 250);
            this.lblRefrerencia.Name = "lblRefrerencia";
            this.lblRefrerencia.Size = new System.Drawing.Size(155, 20);
            this.lblRefrerencia.TabIndex = 2;
            this.lblRefrerencia.Text = "Ponto de Referência";
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(11, 131);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(91, 20);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(11, 90);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = "Bairro";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(11, 41);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 2;
            this.lblCidade.Text = "Cidade";
            // 
            // cbbLogradouro
            // 
            this.cbbLogradouro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbLogradouro.FormattingEnabled = true;
            this.cbbLogradouro.Location = new System.Drawing.Point(15, 154);
            this.cbbLogradouro.Name = "cbbLogradouro";
            this.cbbLogradouro.Size = new System.Drawing.Size(304, 28);
            this.cbbLogradouro.TabIndex = 0;
            // 
            // cbbBairro
            // 
            this.cbbBairro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbBairro.FormattingEnabled = true;
            this.cbbBairro.Location = new System.Drawing.Point(77, 86);
            this.cbbBairro.Name = "cbbBairro";
            this.cbbBairro.Size = new System.Drawing.Size(242, 28);
            this.cbbBairro.TabIndex = 0;
            // 
            // cbbCidade
            // 
            this.cbbCidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbCidade.FormattingEnabled = true;
            this.cbbCidade.Location = new System.Drawing.Point(77, 37);
            this.cbbCidade.Name = "cbbCidade";
            this.cbbCidade.Size = new System.Drawing.Size(242, 28);
            this.cbbCidade.TabIndex = 0;
            // 
            // txtNome
            // 
            this.txtNome.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtNome.Location = new System.Drawing.Point(83, 37);
            this.txtNome.MaxLength = 50;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(306, 26);
            this.txtNome.TabIndex = 0;
            this.txtNome.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmCadastrarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(445, 581);
            this.Controls.Add(this.gpbCadastrarCliente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCadastrarCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.frmCadastrarCliente_Load);
            this.gpbCadastrarCliente.ResumeLayout(false);
            this.gpbCadastrarCliente.PerformLayout();
            this.gpbContatos.ResumeLayout(false);
            this.gpbContatos.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbCadastrarCliente;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.GroupBox gpbContatos;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAdicionarCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.ComboBox cbbCidade;
        private System.Windows.Forms.Button btnAdicionarBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.ComboBox cbbBairro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.ComboBox cbbLogradouro;
        private System.Windows.Forms.Button btnAdicionarLogradouro;
        private System.Windows.Forms.TextBox txtPontoReferencia;
        private System.Windows.Forms.Label lblRefrerencia;
        private System.Windows.Forms.MaskedTextBox mtbCelular;
        private System.Windows.Forms.MaskedTextBox mtbFixo;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblFixo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.TextBox txtNumero;
    }
}