namespace PizzariaZee
{
    partial class TelaEditSabores
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
            this.labelNome = new System.Windows.Forms.Label();
            this.LabelIngrendientes = new System.Windows.Forms.Label();
            this.nomePizzaTextBox = new System.Windows.Forms.TextBox();
            this.ingredientesComboBox = new System.Windows.Forms.ComboBox();
            this.btnAdiconar = new System.Windows.Forms.Button();
            this.saboresEscolhidosListBox = new System.Windows.Forms.ListBox();
            this.especialCheckBoxespecialCheckBox = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnCadastrar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(13, 32);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(118, 20);
            this.labelNome.TabIndex = 0;
            this.labelNome.Text = "Nome da pizza:";
            // 
            // LabelIngrendientes
            // 
            this.LabelIngrendientes.AutoSize = true;
            this.LabelIngrendientes.Location = new System.Drawing.Point(25, 74);
            this.LabelIngrendientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelIngrendientes.Name = "LabelIngrendientes";
            this.LabelIngrendientes.Size = new System.Drawing.Size(106, 20);
            this.LabelIngrendientes.TabIndex = 1;
            this.LabelIngrendientes.Text = "Ingredientes: ";
            // 
            // nomePizzaTextBox
            // 
            this.nomePizzaTextBox.Location = new System.Drawing.Point(139, 29);
            this.nomePizzaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nomePizzaTextBox.Name = "nomePizzaTextBox";
            this.nomePizzaTextBox.Size = new System.Drawing.Size(246, 26);
            this.nomePizzaTextBox.TabIndex = 0;
            // 
            // ingredientesComboBox
            // 
            this.ingredientesComboBox.FormattingEnabled = true;
            this.ingredientesComboBox.Location = new System.Drawing.Point(139, 74);
            this.ingredientesComboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ingredientesComboBox.Name = "ingredientesComboBox";
            this.ingredientesComboBox.Size = new System.Drawing.Size(246, 28);
            this.ingredientesComboBox.TabIndex = 1;
            // 
            // btnAdiconar
            // 
            this.btnAdiconar.Location = new System.Drawing.Point(393, 74);
            this.btnAdiconar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAdiconar.Name = "btnAdiconar";
            this.btnAdiconar.Size = new System.Drawing.Size(142, 38);
            this.btnAdiconar.TabIndex = 3;
            this.btnAdiconar.Text = "Adicionar";
            this.btnAdiconar.UseVisualStyleBackColor = true;
            // 
            // saboresEscolhidosListBox
            // 
            this.saboresEscolhidosListBox.FormattingEnabled = true;
            this.saboresEscolhidosListBox.ItemHeight = 20;
            this.saboresEscolhidosListBox.Location = new System.Drawing.Point(17, 122);
            this.saboresEscolhidosListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saboresEscolhidosListBox.Name = "saboresEscolhidosListBox";
            this.saboresEscolhidosListBox.Size = new System.Drawing.Size(535, 224);
            this.saboresEscolhidosListBox.TabIndex = 4;
            // 
            // especialCheckBoxespecialCheckBox
            // 
            this.especialCheckBoxespecialCheckBox.AutoSize = true;
            this.especialCheckBoxespecialCheckBox.Location = new System.Drawing.Point(393, 29);
            this.especialCheckBoxespecialCheckBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.especialCheckBoxespecialCheckBox.Name = "especialCheckBoxespecialCheckBox";
            this.especialCheckBoxespecialCheckBox.Size = new System.Drawing.Size(142, 24);
            this.especialCheckBoxespecialCheckBox.TabIndex = 2;
            this.especialCheckBoxespecialCheckBox.Text = "Sabor Especial";
            this.especialCheckBoxespecialCheckBox.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(350, 378);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(104, 32);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // BtnCadastrar
            // 
            this.BtnCadastrar.Location = new System.Drawing.Point(462, 378);
            this.BtnCadastrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCadastrar.Name = "BtnCadastrar";
            this.BtnCadastrar.Size = new System.Drawing.Size(102, 32);
            this.BtnCadastrar.TabIndex = 7;
            this.BtnCadastrar.Text = "Cadastrar";
            this.BtnCadastrar.UseVisualStyleBackColor = true;
            this.BtnCadastrar.Click += new System.EventHandler(this.cadastrarBtn_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Location = new System.Drawing.Point(384, 311);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(168, 35);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // TelaEditSabores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(565, 413);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.BtnCadastrar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.especialCheckBoxespecialCheckBox);
            this.Controls.Add(this.saboresEscolhidosListBox);
            this.Controls.Add(this.btnAdiconar);
            this.Controls.Add(this.ingredientesComboBox);
            this.Controls.Add(this.nomePizzaTextBox);
            this.Controls.Add(this.LabelIngrendientes);
            this.Controls.Add(this.labelNome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaEditSabores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Sabor";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox nomePizzaTextBox;
        private System.Windows.Forms.ComboBox ingredientesComboBox;
        private System.Windows.Forms.Button btnAdiconar;
        private System.Windows.Forms.ListBox saboresEscolhidosListBox;
        private System.Windows.Forms.CheckBox especialCheckBoxespecialCheckBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnCadastrar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label LabelIngrendientes;
    }
}