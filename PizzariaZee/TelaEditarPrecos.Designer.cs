namespace PizzariaZee
{
    partial class TelaEditarPrecos
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
            labelValor = new Label();
            labelPizzaGigante = new Label();
            labelExtraGigante = new Label();
            TextBoxValor = new TextBox();
            TextBoxValorAdicional = new TextBox();
            btnSalvar = new Button();
            btnCancelar = new Button();
            listBoxTamanho = new ListBox();
            listBoxCategoria = new ListBox();
            label1 = new Label();
            buttonVisualizar = new Button();
            SuspendLayout();
            // 
            // labelValor
            // 
            labelValor.AutoSize = true;
            labelValor.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelValor.Location = new Point(13, 45);
            labelValor.Margin = new Padding(4, 0, 4, 0);
            labelValor.Name = "labelValor";
            labelValor.Size = new Size(66, 25);
            labelValor.TabIndex = 1;
            labelValor.Text = "Valor";
            labelValor.Click += label2_Click;
            // 
            // labelPizzaGigante
            // 
            labelPizzaGigante.AutoSize = true;
            labelPizzaGigante.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelPizzaGigante.Location = new Point(16, 88);
            labelPizzaGigante.Margin = new Padding(4, 0, 4, 0);
            labelPizzaGigante.Name = "labelPizzaGigante";
            labelPizzaGigante.Size = new Size(256, 25);
            labelPizzaGigante.TabIndex = 2;
            labelPizzaGigante.Text = "Valor adicional da borda:";
            // 
            // labelExtraGigante
            // 
            labelExtraGigante.AutoSize = true;
            labelExtraGigante.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelExtraGigante.Location = new Point(110, 153);
            labelExtraGigante.Margin = new Padding(4, 0, 4, 0);
            labelExtraGigante.Name = "labelExtraGigante";
            labelExtraGigante.Size = new Size(110, 25);
            labelExtraGigante.TabIndex = 3;
            labelExtraGigante.Text = "Tamanho:";
            // 
            // TextBoxValor
            // 
            TextBoxValor.Location = new Point(87, 42);
            TextBoxValor.Margin = new Padding(4, 6, 4, 6);
            TextBoxValor.Name = "TextBoxValor";
            TextBoxValor.Size = new Size(106, 31);
            TextBoxValor.TabIndex = 1;
            TextBoxValor.TextChanged += valorGiganteTB_TextChanged;
            // 
            // TextBoxValorAdicional
            // 
            TextBoxValorAdicional.Location = new Point(269, 85);
            TextBoxValorAdicional.Margin = new Padding(4, 6, 4, 6);
            TextBoxValorAdicional.Name = "TextBoxValorAdicional";
            TextBoxValorAdicional.Size = new Size(127, 31);
            TextBoxValorAdicional.TabIndex = 2;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(512, 418);
            btnSalvar.Margin = new Padding(4, 6, 4, 6);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(120, 50);
            btnSalvar.TabIndex = 7;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += Atualizar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(389, 418);
            btnCancelar.Margin = new Padding(4, 6, 4, 6);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(114, 50);
            btnCancelar.TabIndex = 6;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += cancelBtn_Click;
            // 
            // listBoxTamanho
            // 
            listBoxTamanho.FormattingEnabled = true;
            listBoxTamanho.ItemHeight = 25;
            listBoxTamanho.Location = new Point(27, 187);
            listBoxTamanho.Name = "listBoxTamanho";
            listBoxTamanho.Size = new Size(254, 179);
            listBoxTamanho.TabIndex = 8;
            // 
            // listBoxCategoria
            // 
            listBoxCategoria.FormattingEnabled = true;
            listBoxCategoria.ItemHeight = 25;
            listBoxCategoria.Location = new Point(335, 187);
            listBoxCategoria.Name = "listBoxCategoria";
            listBoxCategoria.Size = new Size(267, 179);
            listBoxCategoria.TabIndex = 9;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Mongolian Baiti", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(410, 153);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(113, 25);
            label1.TabIndex = 10;
            label1.Text = "Categoria:";
            // 
            // buttonVisualizar
            // 
            buttonVisualizar.Location = new Point(27, 375);
            buttonVisualizar.Margin = new Padding(4, 6, 4, 6);
            buttonVisualizar.Name = "buttonVisualizar";
            buttonVisualizar.Size = new Size(166, 50);
            buttonVisualizar.TabIndex = 11;
            buttonVisualizar.Text = "Visualizar Preços";
            buttonVisualizar.UseVisualStyleBackColor = true;
            buttonVisualizar.Click += buttonVisualizar_Click;
            // 
            // TelaEditarPrecos
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(634, 470);
            Controls.Add(buttonVisualizar);
            Controls.Add(label1);
            Controls.Add(listBoxCategoria);
            Controls.Add(listBoxTamanho);
            Controls.Add(btnCancelar);
            Controls.Add(btnSalvar);
            Controls.Add(TextBoxValorAdicional);
            Controls.Add(TextBoxValor);
            Controls.Add(labelExtraGigante);
            Controls.Add(labelPizzaGigante);
            Controls.Add(labelValor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaEditarPrecos";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Preços";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelValor;
        private Label labelPizzaGigante;
        private Label labelExtraGigante;
        private TextBox TextBoxValor;
        private TextBox TextBoxValorAdicional;
        private Button btnSalvar;
        private Button btnCancelar;
        private ListBox listBoxTamanho;
        private ListBox listBoxCategoria;
        private Label label1;
        private Button buttonVisualizar;
    }
}