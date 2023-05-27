namespace PizzariaZee
{
    partial class CadastrarIngrediente
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
            label1 = new Label();
            NomeText = new TextBox();
            labelNome = new Label();
            btnCadastrar = new Button();
            VoltarBtn = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(51, 20);
            label1.TabIndex = 0;
            label1.Text = "label1";
            // 
            // NomeText
            // 
            NomeText.Location = new Point(101, 39);
            NomeText.Margin = new Padding(3, 4, 3, 4);
            NomeText.Name = "NomeText";
            NomeText.Size = new Size(175, 31);
            NomeText.TabIndex = 2;
            NomeText.TextChanged += nomeTB_TextChanged;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(12, 39);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(70, 25);
            labelNome.TabIndex = 3;
            labelNome.Text = "Nome: ";
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(309, 29);
            btnCadastrar.Margin = new Padding(3, 4, 3, 4);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(114, 41);
            btnCadastrar.TabIndex = 8;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // VoltarBtn
            // 
            VoltarBtn.Location = new Point(334, 285);
            VoltarBtn.Margin = new Padding(3, 4, 3, 4);
            VoltarBtn.Name = "VoltarBtn";
            VoltarBtn.Size = new Size(106, 41);
            VoltarBtn.TabIndex = 9;
            VoltarBtn.Text = "Voltar";
            VoltarBtn.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.RowTemplate.Height = 33;
            dataGridView1.Size = new Size(411, 193);
            dataGridView1.TabIndex = 10;
            // 
            // CadastrarIngrediente
            // 
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(452, 339);
            Controls.Add(dataGridView1);
            Controls.Add(VoltarBtn);
            Controls.Add(btnCadastrar);
            Controls.Add(labelNome);
            Controls.Add(NomeText);
            Name = "CadastrarIngrediente";
            Text = "Ingrediente";
            Load += CadastrarIngrediente_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NomeText;
        private Label labelNome;
        private Button btnCadastrar;
        private Button VoltarBtn;
        private DataGridView dataGridView1;
    }
}