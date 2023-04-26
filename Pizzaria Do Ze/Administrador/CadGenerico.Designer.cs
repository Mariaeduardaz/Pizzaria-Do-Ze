namespace Pizzaria_Do_Ze.Administrador
{
    partial class CadGenerico
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
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
            // CEPMaskedTB
            // 
            this.CEPMaskedTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CEPMaskedTB.Location = new System.Drawing.Point(166, 210);
            this.CEPMaskedTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CEPMaskedTB.Mask = "00000-000";
            this.CEPMaskedTB.Name = "CEPMaskedTB";
            this.CEPMaskedTB.Size = new System.Drawing.Size(206, 33);
            this.CEPMaskedTB.TabIndex = 4;
            this.CEPMaskedTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CEPMaskedTB_MaskInputRejected);
            // 
            // CPFMaskedTB
            // 
            this.CPFMaskedTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPFMaskedTB.Location = new System.Drawing.Point(166, 163);
            this.CPFMaskedTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.CPFMaskedTB.Mask = "000.000.000-00";
            this.CPFMaskedTB.Name = "CPFMaskedTB";
            this.CPFMaskedTB.Size = new System.Drawing.Size(206, 33);
            this.CPFMaskedTB.TabIndex = 3;
            this.CPFMaskedTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.CPFMaskedTB_MaskInputRejected);
            // 
            // labelObs
            // 
            this.labelObs.AutoSize = true;
            this.labelObs.Location = new System.Drawing.Point(45, 307);
            this.labelObs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelObs.Name = "labelObs";
            this.labelObs.Size = new System.Drawing.Size(39, 20);
            this.labelObs.TabIndex = 30;
            this.labelObs.Text = "obs:";
            // 
            // labelEndereco
            // 
            this.labelEndereco.AutoSize = true;
            this.labelEndereco.Location = new System.Drawing.Point(5, 264);
            this.labelEndereco.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEndereco.Name = "labelEndereco";
            this.labelEndereco.Size = new System.Drawing.Size(82, 20);
            this.labelEndereco.TabIndex = 29;
            this.labelEndereco.Text = "Endereço:";
            this.labelEndereco.Click += new System.EventHandler(this.labelEndereco_Click);
            // 
            // labelCEP
            // 
            this.labelCEP.AutoSize = true;
            this.labelCEP.Location = new System.Drawing.Point(45, 217);
            this.labelCEP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCEP.Name = "labelCEP";
            this.labelCEP.Size = new System.Drawing.Size(45, 20);
            this.labelCEP.TabIndex = 28;
            this.labelCEP.Text = "CEP:";
            this.labelCEP.Click += new System.EventHandler(this.labelCEP_Click);
            // 
            // labelCPF
            // 
            this.labelCPF.AutoSize = true;
            this.labelCPF.Location = new System.Drawing.Point(45, 164);
            this.labelCPF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelCPF.Name = "labelCPF";
            this.labelCPF.Size = new System.Drawing.Size(44, 20);
            this.labelCPF.TabIndex = 27;
            this.labelCPF.Text = "CPF:";
            this.labelCPF.Click += new System.EventHandler(this.labelCPF_Click);
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(39, 66);
            this.labelEmail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(57, 20);
            this.labelEmail.TabIndex = 26;
            this.labelEmail.Text = "E-mail:";
            this.labelEmail.Click += new System.EventHandler(this.labelEmail_Click);
            // 
            // labelTelefone
            // 
            this.labelTelefone.AutoSize = true;
            this.labelTelefone.Location = new System.Drawing.Point(21, 119);
            this.labelTelefone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTelefone.Name = "labelTelefone";
            this.labelTelefone.Size = new System.Drawing.Size(75, 20);
            this.labelTelefone.TabIndex = 25;
            this.labelTelefone.Text = "Telefone:";
            this.labelTelefone.Click += new System.EventHandler(this.labelTelefone_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(41, 32);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 24;
            this.labelNome.Text = "Nome:";
            this.labelNome.Click += new System.EventHandler(this.labelNome_Click);
            // 
            // complementoTextBox
            // 
            this.complementoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complementoTextBox.Location = new System.Drawing.Point(166, 296);
            this.complementoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.complementoTextBox.Name = "complementoTextBox";
            this.complementoTextBox.Size = new System.Drawing.Size(355, 33);
            this.complementoTextBox.TabIndex = 6;
            this.complementoTextBox.TextChanged += new System.EventHandler(this.complementoTextBox_TextChanged);
            // 
            // enderecoTextBox
            // 
            this.enderecoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enderecoTextBox.Location = new System.Drawing.Point(166, 253);
            this.enderecoTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.enderecoTextBox.Name = "enderecoTextBox";
            this.enderecoTextBox.Size = new System.Drawing.Size(355, 33);
            this.enderecoTextBox.TabIndex = 5;
            this.enderecoTextBox.TextChanged += new System.EventHandler(this.enderecoTextBox_TextChanged);
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailTextBox.Location = new System.Drawing.Point(166, 65);
            this.EmailTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(355, 33);
            this.EmailTextBox.TabIndex = 1;
            this.EmailTextBox.TextChanged += new System.EventHandler(this.EmailTextBox_TextChanged);
            // 
            // TelefoneMaskTB
            // 
            this.TelefoneMaskTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TelefoneMaskTB.Location = new System.Drawing.Point(166, 108);
            this.TelefoneMaskTB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TelefoneMaskTB.Mask = "(99) 0000-0000";
            this.TelefoneMaskTB.Name = "TelefoneMaskTB";
            this.TelefoneMaskTB.Size = new System.Drawing.Size(206, 33);
            this.TelefoneMaskTB.TabIndex = 2;
            this.TelefoneMaskTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.TelefoneMaskTB_MaskInputRejected);
            // 
            // nameTextBot
            // 
            this.nameTextBot.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTextBot.Location = new System.Drawing.Point(166, 22);
            this.nameTextBot.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nameTextBot.Name = "nameTextBot";
            this.nameTextBot.Size = new System.Drawing.Size(332, 33);
            this.nameTextBot.TabIndex = 0;
            this.nameTextBot.TextChanged += new System.EventHandler(this.nameTextBot_TextChanged);
            // 
            // CadGenerico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
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
            this.Name = "CadGenerico";
            this.Size = new System.Drawing.Size(570, 384);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelObs;
        private System.Windows.Forms.Label labelEndereco;
        private System.Windows.Forms.Label labelCEP;
        private System.Windows.Forms.Label labelCPF;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.Label labelTelefone;
        private System.Windows.Forms.Label labelNome;
        public System.Windows.Forms.MaskedTextBox CEPMaskedTB;
        public System.Windows.Forms.MaskedTextBox CPFMaskedTB;
        public System.Windows.Forms.TextBox complementoTextBox;
        public System.Windows.Forms.TextBox enderecoTextBox;
        public System.Windows.Forms.TextBox EmailTextBox;
        public System.Windows.Forms.MaskedTextBox TelefoneMaskTB;
        public System.Windows.Forms.TextBox nameTextBot;
    }
}
