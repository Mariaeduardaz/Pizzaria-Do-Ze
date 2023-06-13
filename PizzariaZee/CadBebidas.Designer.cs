namespace PizzariaZee
{
    partial class CadBebidas
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
            buttonVisualizarCadastro = new Button();
            buttonVoltar = new Button();
            buttonSalvar = new Button();
            label1 = new Label();
            labelML = new Label();
            listBoxTipo = new ListBox();
            listBoxML = new ListBox();
            textBoxNome = new TextBox();
            labelNome = new Label();
            textBoxSabor = new TextBox();
            id_sabor = new Label();
            textBoxValor = new TextBox();
            labelValor = new Label();
            SuspendLayout();
            // 
            // buttonVisualizarCadastro
            // 
            buttonVisualizarCadastro.Location = new Point(45, 481);
            buttonVisualizarCadastro.Name = "buttonVisualizarCadastro";
            buttonVisualizarCadastro.Size = new Size(133, 64);
            buttonVisualizarCadastro.TabIndex = 29;
            buttonVisualizarCadastro.Text = "Visualizar Bebidas";
            buttonVisualizarCadastro.UseVisualStyleBackColor = true;
            buttonVisualizarCadastro.Click += buttonVisualizarCadastro_Click;
            // 
            // buttonVoltar
            // 
            buttonVoltar.Location = new Point(408, 511);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(112, 34);
            buttonVoltar.TabIndex = 28;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(290, 511);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(112, 34);
            buttonSalvar.TabIndex = 27;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(305, 184);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 24;
            label1.Text = "Tipo:";
            // 
            // labelML
            // 
            labelML.AutoSize = true;
            labelML.Location = new Point(86, 184);
            labelML.Name = "labelML";
            labelML.Size = new Size(40, 25);
            labelML.TabIndex = 23;
            labelML.Text = "ML:";
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 25;
            listBoxTipo.Location = new Point(278, 212);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(180, 254);
            listBoxTipo.TabIndex = 21;
            // 
            // listBoxML
            // 
            listBoxML.FormattingEnabled = true;
            listBoxML.ItemHeight = 25;
            listBoxML.Items.AddRange(new object[] { "150", "300", "600", "1000", "1500", "2000" });
            listBoxML.Location = new Point(45, 212);
            listBoxML.Name = "listBoxML";
            listBoxML.Size = new Size(180, 254);
            listBoxML.TabIndex = 19;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(88, 88);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(297, 31);
            textBoxNome.TabIndex = 18;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(17, 94);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(65, 25);
            labelNome.TabIndex = 17;
            labelNome.Text = "Nome:";
            // 
            // textBoxSabor
            // 
            textBoxSabor.Location = new Point(88, 28);
            textBoxSabor.Name = "textBoxSabor";
            textBoxSabor.Size = new Size(150, 31);
            textBoxSabor.TabIndex = 16;
            // 
            // id_sabor
            // 
            id_sabor.AutoSize = true;
            id_sabor.Location = new Point(44, 31);
            id_sabor.Name = "id_sabor";
            id_sabor.Size = new Size(27, 25);
            id_sabor.TabIndex = 15;
            id_sabor.Text = "id";
            // 
            // textBoxValor
            // 
            textBoxValor.Location = new Point(86, 137);
            textBoxValor.Name = "textBoxValor";
            textBoxValor.Size = new Size(297, 31);
            textBoxValor.TabIndex = 30;
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Location = new Point(15, 140);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(56, 25);
            labelValor.TabIndex = 31;
            labelValor.Text = "Valor:";
            // 
            // CadBebidas
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(577, 561);
            Controls.Add(labelValor);
            Controls.Add(textBoxValor);
            Controls.Add(buttonVisualizarCadastro);
            Controls.Add(buttonVoltar);
            Controls.Add(buttonSalvar);
            Controls.Add(label1);
            Controls.Add(labelML);
            Controls.Add(listBoxTipo);
            Controls.Add(listBoxML);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(textBoxSabor);
            Controls.Add(id_sabor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CadBebidas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastrar Bebidas";
            Load += TelaCadastrarBebidas_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonVisualizarCadastro;
        private Button buttonVoltar;
        private Button buttonSalvar;
        private Label label1;
        private Label labelML;
        private ListBox listBoxTipo;
        private ListBox listBoxML;
        private TextBox textBoxNome;
        private Label labelNome;
        private TextBox textBoxSabor;
        private Label id_sabor;
        private TextBox textBoxValor;
        private Label labelValor;
    }
}