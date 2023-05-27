namespace PizzariadoZe.Administrador
{
    partial class CadFornecedor
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
            this.userControl1 = new System.Windows.Forms.UserControl();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.CEPMaskedTB = new System.Windows.Forms.MaskedTextBox();
            this.CPFMaskedTB = new System.Windows.Forms.MaskedTextBox();
            this.labelObs = new System.Windows.Forms.Label();
            this.labelEndereco = new System.Windows.Forms.Label();
            this.labelCEP = new System.Windows.Forms.Label();
            this.labelCPF = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelTelefone = new System.Windows.Forms.Label();
            this.labelNome = new System.Windows.Forms.Label();
            this.complementoTextBox = new System.Windows.Forms.TextBox();
            this.enderecoTextBox = new System.Windows.Forms.TextBox();
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.TelefoneMaskTB = new System.Windows.Forms.MaskedTextBox();
            this.nameTextBot = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // userControl1
            // 
            this.userControl1.Location = new System.Drawing.Point(386, 237);
            this.userControl1.Name = "userControl1";
            this.userControl1.Size = new System.Drawing.Size(150, 150);
            this.userControl1.TabIndex = 0;
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(375, 363);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(134, 38);
            this.BtnCadastrar.TabIndex = 7;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            // 
            // CEPMaskedTB
            // 
            this.CEPMaskedTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEPMaskedTB.Location = new System.Drawing.Point(129, 217);
            this.CEPMaskedTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CEPMaskedTB.Mask = "00000-000";
            this.CEPMaskedTB.Name = "CEPMaskedTB";
            this.CEPMaskedTB.Size = new System.Drawing.Size(206, 33);
            this.CEPMaskedTB.TabIndex = 4;
            // 
            // CPFMaskedTB
            // 
            this.CPFMaskedTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFMaskedTB.Location = new System.Drawing.Point(129, 170);
            this.CPFMaskedTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPFMaskedTB.Mask = "000.000.000-00";
            this.CPFMaskedTB.Name = "CPFMaskedTB";
            this.CPFMaskedTB.Size = new System.Drawing.Size(206, 33);
            this.CPFMaskedTB.TabIndex = 3;
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(60, 313);
            this.labelObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(39, 20);
            this.labelObs.TabIndex = 45;
            this.labelObs.Text = "obs:";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(14, 270);
            this.labelEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(82, 20);
            this.labelEndereco.TabIndex = 44;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(54, 223);
            this.labelCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(45, 20);
            this.labelCEP.TabIndex = 43;
            this.labelCEP.Text = "CEP:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(54, 170);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(44, 20);
            this.labelCPF.TabIndex = 42;
            this.labelCPF.Text = "CPF:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(48, 72);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 20);
            this.labelEmail.TabIndex = 41;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(30, 125);
            this.labelTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(75, 20);
            this.labelTelefone.TabIndex = 40;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(50, 38);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 39;
            this.labelNome.Text = "Nome:";
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complementoTextBox.Location = new System.Drawing.Point(129, 303);
            this.complementoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(355, 33);
            this.complementoTextBox.TabIndex = 6;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTextBox.Location = new System.Drawing.Point(129, 260);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(355, 33);
            this.enderecoTextBox.TabIndex = 5;
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(129, 72);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(355, 33);
            this.EmailTextBox.TabIndex = 1;
            // 
            // TelefoneMaskTB
            // 
            this.TelefoneMaskTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneMaskTB.Location = new System.Drawing.Point(129, 115);
            this.TelefoneMaskTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TelefoneMaskTB.Mask = "(99) 0000-0000";
            this.TelefoneMaskTB.Name = "TelefoneMaskTB";
            this.TelefoneMaskTB.Size = new System.Drawing.Size(206, 33);
            this.TelefoneMaskTB.TabIndex = 2;
            // 
            // nameTextBot
            // 
            this.nameTextBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBot.Location = new System.Drawing.Point(129, 29);
            this.nameTextBot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBot.Name = "nameTextBot";
            this.nameTextBot.Size = new System.Drawing.Size(332, 33);
            this.nameTextBot.TabIndex = 0;
            // 
            // CadFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(529, 413);
            this.Controls.Add(this.CEPMaskedTB);
            this.Controls.Add(this.CPFMaskedTB);
            this.Controls.Add(this.labelObs);
            this.Controls.Add(this.labelEndereco);
            this.Controls.Add(this.labelCEP);
            this.Controls.Add(this.labelCPF);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelTelefone);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.complementoTextBox);
            this.Controls.Add(this.enderecoTextBox);
            this.Controls.Add(this.EmailTextBox);
            this.Controls.Add(this.TelefoneMaskTB);
            this.Controls.Add(this.nameTextBot);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.userControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadFornecedor";
            this.Load += new System.EventHandler(this.CadFornecedor_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.UserControl userControl1;
        private System.Windows.Forms.Button BtnCadastrar;
        public System.Windows.Forms.MaskedTextBox CEPMaskedTB;
        public System.Windows.Forms.MaskedTextBox CPFMaskedTB;
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelNome;
        public System.Windows.Forms.TextBox complementoTextBox;
        public System.Windows.Forms.TextBox enderecoTextBox;
        public System.Windows.Forms.TextBox EmailTextBox;
        public System.Windows.Forms.MaskedTextBox TelefoneMaskTB;
        public System.Windows.Forms.TextBox nameTextBot;
    }
}