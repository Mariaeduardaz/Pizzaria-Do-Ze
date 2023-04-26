namespace Pizzaria_Do_Ze.Telas_cadastros
{
    partial class TelaCadastroCliente
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
            this.cadastrarBtn = new System.Windows.Forms.Button();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.clienteCadastradoBtn = new System.Windows.Forms.Button();
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
            // cadastrarBtn
            // 
            this.cadastrarBtn.Location = new System.Drawing.Point(349, 354);
            this.cadastrarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cadastrarBtn.Name = "cadastrarBtn";
            this.cadastrarBtn.Size = new System.Drawing.Size(130, 43);
            this.cadastrarBtn.TabIndex = 8;
            this.cadastrarBtn.Text = "Cadastrar";
            this.cadastrarBtn.UseVisualStyleBackColor = true;
            this.cadastrarBtn.Click += new System.EventHandler(this.cadastrarBtn_Click);
            // 
            // voltarBtn
            // 
            this.voltarBtn.Location = new System.Drawing.Point(442, 409);
            this.voltarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(142, 30);
            this.voltarBtn.TabIndex = 9;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // clienteCadastradoBtn
            // 
            this.clienteCadastradoBtn.Location = new System.Drawing.Point(207, 353);
            this.clienteCadastradoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clienteCadastradoBtn.Name = "clienteCadastradoBtn";
            this.clienteCadastradoBtn.Size = new System.Drawing.Size(134, 44);
            this.clienteCadastradoBtn.TabIndex = 7;
            this.clienteCadastradoBtn.Text = "Cadastrado";
            this.clienteCadastradoBtn.UseVisualStyleBackColor = true;
            // 
            // CEPMaskedTB
            // 
            this.CEPMaskedTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEPMaskedTB.Location = new System.Drawing.Point(125, 214);
            this.CEPMaskedTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CEPMaskedTB.Mask = "00000-000";
            this.CEPMaskedTB.Name = "CEPMaskedTB";
            this.CEPMaskedTB.Size = new System.Drawing.Size(206, 33);
            this.CEPMaskedTB.TabIndex = 4;
            // 
            // CPFMaskedTB
            // 
            this.CPFMaskedTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFMaskedTB.Location = new System.Drawing.Point(125, 167);
            this.CPFMaskedTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPFMaskedTB.Mask = "000.000.000-00";
            this.CPFMaskedTB.Name = "CPFMaskedTB";
            this.CPFMaskedTB.Size = new System.Drawing.Size(206, 33);
            this.CPFMaskedTB.TabIndex = 3;
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(13, 310);
            this.labelObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(39, 20);
            this.labelObs.TabIndex = 45;
            this.labelObs.Text = "obs:";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(10, 267);
            this.labelEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(82, 20);
            this.labelEndereco.TabIndex = 44;
            this.labelEndereco.Text = "Endereço:";
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(50, 220);
            this.labelCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(45, 20);
            this.labelCEP.TabIndex = 43;
            this.labelCEP.Text = "CEP:";
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(50, 167);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(44, 20);
            this.labelCPF.TabIndex = 42;
            this.labelCPF.Text = "CPF:";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(44, 69);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 20);
            this.labelEmail.TabIndex = 41;
            this.labelEmail.Text = "E-mail:";
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(26, 122);
            this.labelTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(75, 20);
            this.labelTelefone.TabIndex = 40;
            this.labelTelefone.Text = "Telefone:";
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(46, 35);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 39;
            this.labelNome.Text = "Nome:";
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complementoTextBox.Location = new System.Drawing.Point(125, 300);
            this.complementoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(355, 33);
            this.complementoTextBox.TabIndex = 6;
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTextBox.Location = new System.Drawing.Point(125, 257);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(355, 33);
            this.enderecoTextBox.TabIndex = 5;
            this.enderecoTextBox.TextChanged += new System.EventHandler(this.enderecoTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(125, 69);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(355, 33);
            this.EmailTextBox.TabIndex = 1;
            // 
            // TelefoneMaskTB
            // 
            this.TelefoneMaskTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneMaskTB.Location = new System.Drawing.Point(125, 112);
            this.TelefoneMaskTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TelefoneMaskTB.Mask = "(99) 0000-0000";
            this.TelefoneMaskTB.Name = "TelefoneMaskTB";
            this.TelefoneMaskTB.Size = new System.Drawing.Size(206, 33);
            this.TelefoneMaskTB.TabIndex = 2;
            // 
            // nameTextBot
            // 
            this.nameTextBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBot.Location = new System.Drawing.Point(125, 26);
            this.nameTextBot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBot.Name = "nameTextBot";
            this.nameTextBot.Size = new System.Drawing.Size(332, 33);
            this.nameTextBot.TabIndex = 0;
            // 
            // TelaCadastroCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(590, 445);
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
            this.Controls.Add(this.clienteCadastradoBtn);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.cadastrarBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaCadastroCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro Cliente";
            this.Load += new System.EventHandler(this.TelaCadastroCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cadastrarBtn;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Button clienteCadastradoBtn;
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