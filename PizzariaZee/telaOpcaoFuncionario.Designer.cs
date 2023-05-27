namespace PizzariaZee
{
    partial class telaOpcaoFuncionario
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
            btnCadastrarfuncionario = new Button();
            btnvvisualizarfuncionario = new Button();
            SuspendLayout();
            // 
            // btnCadastrarfuncionario
            // 
            btnCadastrarfuncionario.Location = new Point(47, 61);
            btnCadastrarfuncionario.Name = "btnCadastrarfuncionario";
            btnCadastrarfuncionario.Size = new Size(211, 34);
            btnCadastrarfuncionario.TabIndex = 0;
            btnCadastrarfuncionario.Text = "Cadastrar Funcionario";
            btnCadastrarfuncionario.UseVisualStyleBackColor = true;
            btnCadastrarfuncionario.Click += btnCadastrarfuncionario_Click;
            // 
            // btnvvisualizarfuncionario
            // 
            btnvvisualizarfuncionario.Location = new Point(47, 136);
            btnvvisualizarfuncionario.Name = "btnvvisualizarfuncionario";
            btnvvisualizarfuncionario.Size = new Size(211, 34);
            btnvvisualizarfuncionario.TabIndex = 1;
            btnvvisualizarfuncionario.Text = "Visualizar Funcionario";
            btnvvisualizarfuncionario.UseVisualStyleBackColor = true;
            btnvvisualizarfuncionario.Click += btnvvisualizarfuncionario_Click;
            // 
            // telaOpcaoFuncionario
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(324, 253);
            Controls.Add(btnvvisualizarfuncionario);
            Controls.Add(btnCadastrarfuncionario);
            Name = "telaOpcaoFuncionario";
            Text = "telaOpcaoFuncionario";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastrarfuncionario;
        private Button btnvvisualizarfuncionario;
    }
}