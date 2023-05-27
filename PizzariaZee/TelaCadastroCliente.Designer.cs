namespace PizzariaZee
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
            cadastrarBtn = new Button();
            voltarBtn = new Button();
            maskedTexBoxCEP = new MaskedTextBox();
            CPFMaskedTB = new MaskedTextBox();
            labelObs = new Label();
            labelEndereco = new Label();
            labelCEP = new Label();
            labelCPF = new Label();
            labelEmail = new Label();
            labelTelefone = new Label();
            labelNome = new Label();
            complementoTextBox = new TextBox();
            enderecoTextBox = new TextBox();
            emailTextBox = new TextBox();
            numeroTextBox = new MaskedTextBox();
            nomeTextBot = new TextBox();
            label1 = new Label();
            textBoxPais = new TextBox();
            label2 = new Label();
            comboBoxUF = new ComboBox();
            label3 = new Label();
            textBoxCidade = new TextBox();
            label4 = new Label();
            textBoxBairro = new TextBox();
            label5 = new Label();
            textBoxLogradouro = new TextBox();
            label6 = new Label();
            idTextBox = new TextBox();
            textBox1 = new TextBox();
            label7 = new Label();
            SuspendLayout();
            // 
            // cadastrarBtn
            // 
            cadastrarBtn.Location = new Point(440, 467);
            cadastrarBtn.Margin = new Padding(4, 6, 4, 6);
            cadastrarBtn.Name = "cadastrarBtn";
            cadastrarBtn.Size = new Size(157, 38);
            cadastrarBtn.TabIndex = 8;
            cadastrarBtn.Text = "Cadastrar";
            cadastrarBtn.UseVisualStyleBackColor = true;
            cadastrarBtn.Click += cadastrarBtn_Click;
            // 
            // voltarBtn
            // 
            voltarBtn.Location = new Point(262, 467);
            voltarBtn.Margin = new Padding(4, 6, 4, 6);
            voltarBtn.Name = "voltarBtn";
            voltarBtn.Size = new Size(158, 38);
            voltarBtn.TabIndex = 9;
            voltarBtn.Text = "Voltar";
            voltarBtn.UseVisualStyleBackColor = true;
            voltarBtn.Click += voltarBtn_Click;
            // 
            // maskedTexBoxCEP
            // 
            maskedTexBoxCEP.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            maskedTexBoxCEP.Location = new Point(139, 268);
            maskedTexBoxCEP.Margin = new Padding(4, 6, 4, 6);
            maskedTexBoxCEP.Mask = "00000-000";
            maskedTexBoxCEP.Name = "maskedTexBoxCEP";
            maskedTexBoxCEP.Size = new Size(228, 33);
            maskedTexBoxCEP.TabIndex = 4;
            maskedTexBoxCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTexBoxCEP.Leave += maskedTexBoxCEP_Leave;
            // 
            // CPFMaskedTB
            // 
            CPFMaskedTB.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            CPFMaskedTB.Location = new Point(139, 209);
            CPFMaskedTB.Margin = new Padding(4, 6, 4, 6);
            CPFMaskedTB.Mask = "000.000.000-00";
            CPFMaskedTB.Name = "CPFMaskedTB";
            CPFMaskedTB.Size = new Size(228, 33);
            CPFMaskedTB.TabIndex = 3;
            CPFMaskedTB.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // labelObs
            // 
            labelObs.AutoSize = true;
            labelObs.Location = new Point(56, 383);
            labelObs.Margin = new Padding(4, 0, 4, 0);
            labelObs.Name = "labelObs";
            labelObs.Size = new Size(46, 25);
            labelObs.TabIndex = 45;
            labelObs.Text = "obs:";
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Location = new Point(29, 329);
            labelEndereco.Margin = new Padding(4, 0, 4, 0);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(89, 25);
            labelEndereco.TabIndex = 44;
            labelEndereco.Text = "Endereço:";
            // 
            // labelCEP
            // 
            labelCEP.AutoSize = true;
            labelCEP.Location = new Point(56, 275);
            labelCEP.Margin = new Padding(4, 0, 4, 0);
            labelCEP.Name = "labelCEP";
            labelCEP.Size = new Size(46, 25);
            labelCEP.TabIndex = 43;
            labelCEP.Text = "CEP:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(56, 209);
            labelCPF.Margin = new Padding(4, 0, 4, 0);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(46, 25);
            labelCPF.TabIndex = 42;
            labelCPF.Text = "CPF:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Location = new Point(53, 97);
            labelEmail.Margin = new Padding(4, 0, 4, 0);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(65, 25);
            labelEmail.TabIndex = 41;
            labelEmail.Text = "E-mail:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(29, 152);
            labelTelefone.Margin = new Padding(4, 0, 4, 0);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(81, 25);
            labelTelefone.TabIndex = 40;
            labelTelefone.Text = "Telefone:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(51, 44);
            labelNome.Margin = new Padding(4, 0, 4, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(65, 25);
            labelNome.TabIndex = 39;
            labelNome.Text = "Nome:";
            // 
            // complementoTextBox
            // 
            complementoTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            complementoTextBox.Location = new Point(139, 375);
            complementoTextBox.Margin = new Padding(4, 6, 4, 6);
            complementoTextBox.Name = "complementoTextBox";
            complementoTextBox.Size = new Size(394, 33);
            complementoTextBox.TabIndex = 6;
            // 
            // enderecoTextBox
            // 
            enderecoTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            enderecoTextBox.Location = new Point(139, 321);
            enderecoTextBox.Margin = new Padding(4, 6, 4, 6);
            enderecoTextBox.Name = "enderecoTextBox";
            enderecoTextBox.Size = new Size(394, 33);
            enderecoTextBox.TabIndex = 5;
            enderecoTextBox.TextChanged += enderecoTextBox_TextChanged;
            // 
            // emailTextBox
            // 
            emailTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            emailTextBox.Location = new Point(139, 93);
            emailTextBox.Margin = new Padding(4, 6, 4, 6);
            emailTextBox.Name = "emailTextBox";
            emailTextBox.Size = new Size(327, 33);
            emailTextBox.TabIndex = 1;
            // 
            // numeroTextBox
            // 
            numeroTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            numeroTextBox.Location = new Point(139, 140);
            numeroTextBox.Margin = new Padding(4, 6, 4, 6);
            numeroTextBox.Mask = "(99) 0000-0000";
            numeroTextBox.Name = "numeroTextBox";
            numeroTextBox.Size = new Size(228, 33);
            numeroTextBox.TabIndex = 2;
            numeroTextBox.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // nomeTextBot
            // 
            nomeTextBot.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            nomeTextBot.Location = new Point(139, 48);
            nomeTextBot.Margin = new Padding(4, 6, 4, 6);
            nomeTextBot.Name = "nomeTextBot";
            nomeTextBot.Size = new Size(368, 33);
            nomeTextBot.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(574, 92);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 46;
            label1.Text = "Pais:";
            // 
            // textBoxPais
            // 
            textBoxPais.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPais.Location = new Point(640, 86);
            textBoxPais.Margin = new Padding(4, 6, 4, 6);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(248, 33);
            textBoxPais.TabIndex = 47;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(574, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 48;
            label2.Text = "UF:";
            // 
            // comboBoxUF
            // 
            comboBoxUF.FormattingEnabled = true;
            comboBoxUF.Location = new Point(640, 143);
            comboBoxUF.Name = "comboBoxUF";
            comboBoxUF.Size = new Size(182, 33);
            comboBoxUF.TabIndex = 49;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(562, 206);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 50;
            label3.Text = "Cidade:";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(640, 206);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(150, 31);
            textBoxCidade.TabIndex = 51;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(562, 263);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 52;
            label4.Text = "Bairro:";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(640, 263);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(150, 31);
            textBoxBairro.TabIndex = 53;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(562, 322);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 54;
            label5.Text = "Logradouro:";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(678, 319);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(150, 31);
            textBoxLogradouro.TabIndex = 55;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(578, 47);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 56;
            label6.Text = "ID:";
            // 
            // idTextBox
            // 
            idTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            idTextBox.Location = new Point(664, 41);
            idTextBox.Margin = new Padding(4, 6, 4, 6);
            idTextBox.Name = "idTextBox";
            idTextBox.Size = new Size(368, 33);
            idTextBox.TabIndex = 57;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBox1.Location = new Point(139, 3);
            textBox1.Margin = new Padding(4, 6, 4, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(368, 33);
            textBox1.TabIndex = 58;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(88, 6);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 25);
            label7.TabIndex = 59;
            label7.Text = "ID:";
            // 
            // TelaCadastroCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(1045, 515);
            Controls.Add(label7);
            Controls.Add(textBox1);
            Controls.Add(idTextBox);
            Controls.Add(label6);
            Controls.Add(textBoxLogradouro);
            Controls.Add(label5);
            Controls.Add(textBoxBairro);
            Controls.Add(label4);
            Controls.Add(textBoxCidade);
            Controls.Add(label3);
            Controls.Add(comboBoxUF);
            Controls.Add(label2);
            Controls.Add(textBoxPais);
            Controls.Add(label1);
            Controls.Add(maskedTexBoxCEP);
            Controls.Add(CPFMaskedTB);
            Controls.Add(labelObs);
            Controls.Add(labelEndereco);
            Controls.Add(labelCEP);
            Controls.Add(labelCPF);
            Controls.Add(labelEmail);
            Controls.Add(labelTelefone);
            Controls.Add(labelNome);
            Controls.Add(complementoTextBox);
            Controls.Add(enderecoTextBox);
            Controls.Add(emailTextBox);
            Controls.Add(numeroTextBox);
            Controls.Add(nomeTextBot);
            Controls.Add(voltarBtn);
            Controls.Add(cadastrarBtn);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaCadastroCliente";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro Cliente";
            FormClosing += TelaCadastroCliente_FormClosing;
            Load += TelaCadastroCliente_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cadastrarBtn;
        private Button voltarBtn;
        public MaskedTextBox maskedTexBoxCEP;
        public MaskedTextBox CPFMaskedTB;
        private Label labelObs;
        private Label labelEndereco;
        private Label labelCEP;
        private Label labelCPF;
        private Label labelEmail;
        private Label labelTelefone;
        private Label labelNome;
        public TextBox complementoTextBox;
        public TextBox enderecoTextBox;
        public TextBox emailTextBox;
        public MaskedTextBox numeroTextBox;
        public TextBox nomeTextBot;
        private Label label1;
        public TextBox textBoxPais;
        private Label label2;
        private ComboBox comboBoxUF;
        private Label label3;
        private TextBox textBoxCidade;
        private Label label4;
        private TextBox textBoxBairro;
        private Label label5;
        private TextBox textBoxLogradouro;
        private Label label6;
        public TextBox idTextBox;
        public TextBox textBox1;
        private Label label7;
    }
}