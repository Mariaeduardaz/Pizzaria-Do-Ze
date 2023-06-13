namespace PizzariaZee
{
    partial class CadastrarSabor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadastrarSabor));
            id_sabor = new Label();
            textBoxSabor = new TextBox();
            labelNome = new Label();
            textBoxNome = new TextBox();
            listBoxCategoria = new ListBox();
            checkedListBoxIngredientes = new CheckedListBox();
            listBoxTipo = new ListBox();
            pictureBoxImagem = new PictureBox();
            labelCategoria = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            buttonSalvar = new Button();
            buttonVoltar = new Button();
            buttonVisualizarCadastro = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).BeginInit();
            SuspendLayout();
            // 
            // id_sabor
            // 
            id_sabor.AutoSize = true;
            id_sabor.Location = new Point(33, 29);
            id_sabor.Name = "id_sabor";
            id_sabor.Size = new Size(27, 25);
            id_sabor.TabIndex = 0;
            id_sabor.Text = "id";
            // 
            // textBoxSabor
            // 
            textBoxSabor.Location = new Point(77, 26);
            textBoxSabor.Name = "textBoxSabor";
            textBoxSabor.Size = new Size(150, 31);
            textBoxSabor.TabIndex = 1;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Location = new Point(6, 92);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(65, 25);
            labelNome.TabIndex = 2;
            labelNome.Text = "Nome:";
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(77, 92);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(297, 31);
            textBoxNome.TabIndex = 3;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 25;
            listBoxCategoria.Location = new Point(47, 161);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(180, 129);
            listBoxCategoria.TabIndex = 4;
            // 
            // checkedListBoxIngredientes
            // 
            checkedListBoxIngredientes.FormattingEnabled = true;
            checkedListBoxIngredientes.Location = new Point(565, 59);
            checkedListBoxIngredientes.Name = "checkedListBoxIngredientes";
            checkedListBoxIngredientes.Size = new Size(233, 368);
            checkedListBoxIngredientes.TabIndex = 5;
            // 
            // listBoxTipo
            // 
            listBoxTipo.FormattingEnabled = true;
            listBoxTipo.ItemHeight = 25;
            listBoxTipo.Location = new Point(257, 161);
            listBoxTipo.Name = "listBoxTipo";
            listBoxTipo.Size = new Size(180, 129);
            listBoxTipo.TabIndex = 6;
            // 
            // pictureBoxImagem
            // 
            pictureBoxImagem.Image = (Image)resources.GetObject("pictureBoxImagem.Image");
            pictureBoxImagem.Location = new Point(47, 339);
            pictureBoxImagem.Name = "pictureBoxImagem";
            pictureBoxImagem.Size = new Size(412, 75);
            pictureBoxImagem.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBoxImagem.TabIndex = 7;
            pictureBoxImagem.TabStop = false;
            pictureBoxImagem.Click += pictureBoxImagem_Click;
            // 
            // labelCategoria
            // 
            labelCategoria.AutoSize = true;
            labelCategoria.Location = new Point(88, 133);
            labelCategoria.Name = "labelCategoria";
            labelCategoria.Size = new Size(92, 25);
            labelCategoria.TabIndex = 8;
            labelCategoria.Text = "Categoria:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 133);
            label1.Name = "label1";
            label1.Size = new Size(51, 25);
            label1.TabIndex = 9;
            label1.Text = "Tipo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 311);
            label2.Name = "label2";
            label2.Size = new Size(53, 25);
            label2.TabIndex = 10;
            label2.Text = "Foto:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(624, 32);
            label3.Name = "label3";
            label3.Size = new Size(116, 25);
            label3.TabIndex = 11;
            label3.Text = "Ingrendiente:";
            // 
            // buttonSalvar
            // 
            buttonSalvar.Location = new Point(565, 434);
            buttonSalvar.Name = "buttonSalvar";
            buttonSalvar.Size = new Size(112, 34);
            buttonSalvar.TabIndex = 12;
            buttonSalvar.Text = "Salvar";
            buttonSalvar.UseVisualStyleBackColor = true;
            buttonSalvar.Click += buttonSalvar_Click;
            // 
            // buttonVoltar
            // 
            buttonVoltar.Location = new Point(686, 434);
            buttonVoltar.Name = "buttonVoltar";
            buttonVoltar.Size = new Size(112, 34);
            buttonVoltar.TabIndex = 13;
            buttonVoltar.Text = "Voltar";
            buttonVoltar.UseVisualStyleBackColor = true;
            // 
            // buttonVisualizarCadastro
            // 
            buttonVisualizarCadastro.Location = new Point(426, 59);
            buttonVisualizarCadastro.Name = "buttonVisualizarCadastro";
            buttonVisualizarCadastro.Size = new Size(133, 64);
            buttonVisualizarCadastro.TabIndex = 14;
            buttonVisualizarCadastro.Text = "Visualizar Sabor";
            buttonVisualizarCadastro.UseVisualStyleBackColor = true;
            buttonVisualizarCadastro.Click += buttonVisualizarCadastro_Click;
            // 
            // CadastrarSabor
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(810, 497);
            Controls.Add(buttonVisualizarCadastro);
            Controls.Add(buttonVoltar);
            Controls.Add(buttonSalvar);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labelCategoria);
            Controls.Add(pictureBoxImagem);
            Controls.Add(listBoxTipo);
            Controls.Add(checkedListBoxIngredientes);
            Controls.Add(listBoxCategoria);
            Controls.Add(textBoxNome);
            Controls.Add(labelNome);
            Controls.Add(textBoxSabor);
            Controls.Add(id_sabor);
            Name = "CadastrarSabor";
            Text = "CadastrarSabor";
            ((System.ComponentModel.ISupportInitialize)pictureBoxImagem).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label id_sabor;
        private TextBox textBoxSabor;
        private Label labelNome;
        private TextBox textBoxNome;
        private ListBox listBoxCategoria;
        private CheckedListBox checkedListBoxIngredientes;
        private ListBox listBoxTipo;
        private PictureBox pictureBoxImagem;
        private Label labelCategoria;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button buttonSalvar;
        private Button buttonVoltar;
        private Button buttonVisualizarCadastro;
    }
}