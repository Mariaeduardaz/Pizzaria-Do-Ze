namespace PizzariaZee
{
    partial class cadFuncionario
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
            cnhMaskedTB = new MaskedTextBox();
            entregadorRadioBtn = new RadioButton();
            AtendenteRadioBtn = new RadioButton();
            adminRadioBtn = new RadioButton();
            senhaMaskedTB = new MaskedTextBox();
            telefonemaskedTB = new MaskedTextBox();
            cpfMaskedTB = new MaskedTextBox();
            matriculaTB = new TextBox();
            nomeTB = new TextBox();
            labelCNH = new Label();
            labelGrupo = new Label();
            labelSenha = new Label();
            labelMatricula = new Label();
            labelTelefone = new Label();
            labelCPF = new Label();
            labelNome = new Label();
            btnCadastrar = new Button();
            btnCancelar = new Button();
            idEnderecoTextBox = new TextBox();
            label6 = new Label();
            textBoxLogradouro = new TextBox();
            label5 = new Label();
            textBoxBairro = new TextBox();
            label4 = new Label();
            textBoxCidade = new TextBox();
            label3 = new Label();
            comboBoxUF = new ComboBox();
            label2 = new Label();
            textBoxPais = new TextBox();
            label1 = new Label();
            maskedTextBoxCEP = new MaskedTextBox();
            label7 = new Label();
            dateTimePickerValidade = new DateTimePicker();
            label8 = new Label();
            textBoxComplemento = new TextBox();
            label9 = new Label();
            textBoxNumero = new TextBox();
            label10 = new Label();
            textBoxObs = new TextBox();
            label11 = new Label();
            textBoxEmail = new TextBox();
            label12 = new Label();
            SuspendLayout();
            // 
            // cnhMaskedTB
            // 
            cnhMaskedTB.Location = new Point(173, 498);
            cnhMaskedTB.Margin = new Padding(4, 6, 4, 6);
            cnhMaskedTB.Mask = "00000000000";
            cnhMaskedTB.Name = "cnhMaskedTB";
            cnhMaskedTB.Size = new Size(164, 31);
            cnhMaskedTB.TabIndex = 8;
            // 
            // entregadorRadioBtn
            // 
            entregadorRadioBtn.AutoSize = true;
            entregadorRadioBtn.Location = new Point(173, 449);
            entregadorRadioBtn.Margin = new Padding(4, 6, 4, 6);
            entregadorRadioBtn.Name = "entregadorRadioBtn";
            entregadorRadioBtn.Size = new Size(125, 29);
            entregadorRadioBtn.TabIndex = 7;
            entregadorRadioBtn.TabStop = true;
            entregadorRadioBtn.Text = "Entregador";
            entregadorRadioBtn.UseVisualStyleBackColor = true;
            // 
            // AtendenteRadioBtn
            // 
            AtendenteRadioBtn.AutoSize = true;
            AtendenteRadioBtn.Location = new Point(173, 405);
            AtendenteRadioBtn.Margin = new Padding(4, 6, 4, 6);
            AtendenteRadioBtn.Name = "AtendenteRadioBtn";
            AtendenteRadioBtn.Size = new Size(119, 29);
            AtendenteRadioBtn.TabIndex = 6;
            AtendenteRadioBtn.TabStop = true;
            AtendenteRadioBtn.Text = "Atendente";
            AtendenteRadioBtn.UseVisualStyleBackColor = true;
            // 
            // adminRadioBtn
            // 
            adminRadioBtn.AutoSize = true;
            adminRadioBtn.Location = new Point(173, 364);
            adminRadioBtn.Margin = new Padding(4, 6, 4, 6);
            adminRadioBtn.Name = "adminRadioBtn";
            adminRadioBtn.Size = new Size(151, 29);
            adminRadioBtn.TabIndex = 5;
            adminRadioBtn.TabStop = true;
            adminRadioBtn.Text = "Administrador";
            adminRadioBtn.UseVisualStyleBackColor = true;
            // 
            // senhaMaskedTB
            // 
            senhaMaskedTB.Location = new Point(173, 266);
            senhaMaskedTB.Margin = new Padding(4, 6, 4, 6);
            senhaMaskedTB.Name = "senhaMaskedTB";
            senhaMaskedTB.PasswordChar = '*';
            senhaMaskedTB.Size = new Size(164, 31);
            senhaMaskedTB.TabIndex = 4;
            senhaMaskedTB.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // telefonemaskedTB
            // 
            telefonemaskedTB.Location = new Point(174, 127);
            telefonemaskedTB.Margin = new Padding(4, 6, 4, 6);
            telefonemaskedTB.Mask = "(00)00000-0000";
            telefonemaskedTB.Name = "telefonemaskedTB";
            telefonemaskedTB.Size = new Size(164, 31);
            telefonemaskedTB.TabIndex = 2;
            telefonemaskedTB.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // cpfMaskedTB
            // 
            cpfMaskedTB.Location = new Point(174, 77);
            cpfMaskedTB.Margin = new Padding(4, 6, 4, 6);
            cpfMaskedTB.Mask = "000.000.000-00";
            cpfMaskedTB.Name = "cpfMaskedTB";
            cpfMaskedTB.Size = new Size(164, 31);
            cpfMaskedTB.TabIndex = 1;
            cpfMaskedTB.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            // 
            // matriculaTB
            // 
            matriculaTB.Location = new Point(174, 177);
            matriculaTB.Margin = new Padding(4, 6, 4, 6);
            matriculaTB.Name = "matriculaTB";
            matriculaTB.Size = new Size(164, 31);
            matriculaTB.TabIndex = 3;
            // 
            // nomeTB
            // 
            nomeTB.Location = new Point(173, 30);
            nomeTB.Margin = new Padding(4, 6, 4, 6);
            nomeTB.Name = "nomeTB";
            nomeTB.Size = new Size(164, 31);
            nomeTB.TabIndex = 0;
            // 
            // labelCNH
            // 
            labelCNH.AutoSize = true;
            labelCNH.Location = new Point(91, 501);
            labelCNH.Margin = new Padding(4, 0, 4, 0);
            labelCNH.Name = "labelCNH";
            labelCNH.Size = new Size(53, 25);
            labelCNH.TabIndex = 26;
            labelCNH.Text = "CNH:";
            // 
            // labelGrupo
            // 
            labelGrupo.AutoSize = true;
            labelGrupo.Location = new Point(79, 405);
            labelGrupo.Margin = new Padding(4, 0, 4, 0);
            labelGrupo.Name = "labelGrupo";
            labelGrupo.Size = new Size(66, 25);
            labelGrupo.TabIndex = 25;
            labelGrupo.Text = "Grupo:";
            // 
            // labelSenha
            // 
            labelSenha.AutoSize = true;
            labelSenha.Location = new Point(79, 266);
            labelSenha.Margin = new Padding(4, 0, 4, 0);
            labelSenha.Name = "labelSenha";
            labelSenha.Size = new Size(64, 25);
            labelSenha.TabIndex = 24;
            labelSenha.Text = "Senha:";
            // 
            // labelMatricula
            // 
            labelMatricula.AutoSize = true;
            labelMatricula.Location = new Point(63, 179);
            labelMatricula.Margin = new Padding(4, 0, 4, 0);
            labelMatricula.Name = "labelMatricula";
            labelMatricula.Size = new Size(88, 25);
            labelMatricula.TabIndex = 23;
            labelMatricula.Text = "Matricula:";
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Location = new Point(63, 131);
            labelTelefone.Margin = new Padding(4, 0, 4, 0);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(81, 25);
            labelTelefone.TabIndex = 22;
            labelTelefone.Text = "Telefone:";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Location = new Point(98, 85);
            labelCPF.Margin = new Padding(4, 0, 4, 0);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(46, 25);
            labelCPF.TabIndex = 21;
            labelCPF.Text = "CPF:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(84, 30);
            labelNome.Margin = new Padding(4, 0, 4, 0);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(65, 25);
            labelNome.TabIndex = 20;
            labelNome.Text = "Nome:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(778, 602);
            btnCadastrar.Margin = new Padding(4, 6, 4, 6);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(124, 44);
            btnCadastrar.TabIndex = 10;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(645, 602);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(124, 44);
            btnCancelar.TabIndex = 9;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // idEnderecoTextBox
            // 
            idEnderecoTextBox.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            idEnderecoTextBox.Location = new Point(571, 32);
            idEnderecoTextBox.Margin = new Padding(4, 6, 4, 6);
            idEnderecoTextBox.Name = "idEnderecoTextBox";
            idEnderecoTextBox.Size = new Size(72, 33);
            idEnderecoTextBox.TabIndex = 69;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(493, 36);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(34, 25);
            label6.TabIndex = 68;
            label6.Text = "ID:";
            // 
            // textBoxLogradouro
            // 
            textBoxLogradouro.Location = new Point(610, 311);
            textBoxLogradouro.Name = "textBoxLogradouro";
            textBoxLogradouro.Size = new Size(150, 31);
            textBoxLogradouro.TabIndex = 67;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(493, 311);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(110, 25);
            label5.TabIndex = 66;
            label5.Text = "Logradouro:";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(571, 249);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(189, 31);
            textBoxBairro.TabIndex = 65;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(493, 252);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(62, 25);
            label4.TabIndex = 64;
            label4.Text = "Bairro:";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(571, 192);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(189, 31);
            textBoxCidade.TabIndex = 63;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(493, 195);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(71, 25);
            label3.TabIndex = 62;
            label3.Text = "Cidade:";
            // 
            // comboBoxUF
            // 
            comboBoxUF.FormattingEnabled = true;
            comboBoxUF.Location = new Point(571, 132);
            comboBoxUF.Name = "comboBoxUF";
            comboBoxUF.Size = new Size(189, 33);
            comboBoxUF.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(493, 135);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(37, 25);
            label2.TabIndex = 60;
            label2.Text = "UF:";
            // 
            // textBoxPais
            // 
            textBoxPais.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxPais.Location = new Point(571, 77);
            textBoxPais.Margin = new Padding(4, 6, 4, 6);
            textBoxPais.Name = "textBoxPais";
            textBoxPais.Size = new Size(189, 33);
            textBoxPais.TabIndex = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(493, 81);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(46, 25);
            label1.TabIndex = 58;
            label1.Text = "Pais:";
            // 
            // maskedTextBoxCEP
            // 
            maskedTextBoxCEP.Location = new Point(173, 315);
            maskedTextBoxCEP.Margin = new Padding(4, 6, 4, 6);
            maskedTextBoxCEP.Mask = "00000-000";
            maskedTextBoxCEP.Name = "maskedTextBoxCEP";
            maskedTextBoxCEP.Size = new Size(164, 31);
            maskedTextBoxCEP.TabIndex = 70;
            maskedTextBoxCEP.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            maskedTextBoxCEP.Leave += maskedTextBoxCEP_Leave;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(97, 318);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(46, 25);
            label7.TabIndex = 71;
            label7.Text = "CEP:";
            // 
            // dateTimePickerValidade
            // 
            dateTimePickerValidade.Location = new Point(173, 548);
            dateTimePickerValidade.Name = "dateTimePickerValidade";
            dateTimePickerValidade.Size = new Size(300, 31);
            dateTimePickerValidade.TabIndex = 72;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(25, 554);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(125, 25);
            label8.TabIndex = 73;
            label8.Text = "Validade CNH:";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(630, 419);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(130, 31);
            textBoxComplemento.TabIndex = 77;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(493, 419);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(130, 25);
            label9.TabIndex = 76;
            label9.Text = "Complemento:";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(571, 359);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(189, 31);
            textBoxNumero.TabIndex = 75;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(493, 362);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(81, 25);
            label10.TabIndex = 74;
            label10.Text = "Numero:";
            // 
            // textBoxObs
            // 
            textBoxObs.Location = new Point(173, 598);
            textBoxObs.Name = "textBoxObs";
            textBoxObs.Size = new Size(130, 31);
            textBoxObs.TabIndex = 79;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(100, 598);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(49, 25);
            label11.TabIndex = 78;
            label11.Text = "Obs:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(174, 223);
            textBoxEmail.Margin = new Padding(4, 6, 4, 6);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(164, 31);
            textBoxEmail.TabIndex = 80;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(85, 223);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(58, 25);
            label12.TabIndex = 81;
            label12.Text = "Email:";
            // 
            // cadFuncionario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(919, 661);
            Controls.Add(textBoxEmail);
            Controls.Add(label12);
            Controls.Add(textBoxObs);
            Controls.Add(label11);
            Controls.Add(textBoxComplemento);
            Controls.Add(label9);
            Controls.Add(textBoxNumero);
            Controls.Add(label10);
            Controls.Add(label8);
            Controls.Add(dateTimePickerValidade);
            Controls.Add(maskedTextBoxCEP);
            Controls.Add(label7);
            Controls.Add(idEnderecoTextBox);
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
            Controls.Add(btnCadastrar);
            Controls.Add(btnCancelar);
            Controls.Add(cnhMaskedTB);
            Controls.Add(entregadorRadioBtn);
            Controls.Add(AtendenteRadioBtn);
            Controls.Add(adminRadioBtn);
            Controls.Add(senhaMaskedTB);
            Controls.Add(telefonemaskedTB);
            Controls.Add(cpfMaskedTB);
            Controls.Add(matriculaTB);
            Controls.Add(nomeTB);
            Controls.Add(labelCNH);
            Controls.Add(labelGrupo);
            Controls.Add(labelSenha);
            Controls.Add(labelMatricula);
            Controls.Add(labelTelefone);
            Controls.Add(labelCPF);
            Controls.Add(labelNome);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "cadFuncionario";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "cadFuncionario";
            FormClosing += cadFuncionario_FormClosing;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MaskedTextBox cnhMaskedTB;
        private RadioButton entregadorRadioBtn;
        private RadioButton AtendenteRadioBtn;
        private RadioButton adminRadioBtn;
        private MaskedTextBox senhaMaskedTB;
        private MaskedTextBox telefonemaskedTB;
        private MaskedTextBox cpfMaskedTB;
        private TextBox matriculaTB;
        private TextBox nomeTB;
        private Label labelCNH;
        private Label labelGrupo;
        private Label labelSenha;
        private Label labelMatricula;
        private Label labelTelefone;
        private Label labelCPF;
        private Label labelNome;
        private Button btnCadastrar;
        private Button btnCancelar;
        public TextBox idEnderecoTextBox;
        private Label label6;
        private TextBox textBoxLogradouro;
        private Label label5;
        private TextBox textBoxBairro;
        private Label label4;
        private TextBox textBoxCidade;
        private Label label3;
        private ComboBox comboBoxUF;
        private Label label2;
        public TextBox textBoxPais;
        private Label label1;
        private MaskedTextBox maskedTextBoxCEP;
        private Label label7;
        private DateTimePicker dateTimePickerValidade;
        private Label label8;
        private TextBox textBoxComplemento;
        private Label label9;
        private TextBox textBoxNumero;
        private Label label10;
        private TextBox textBoxObs;
        private Label label11;
        private TextBox textBoxEmail;
        private Label label12;
    }
}