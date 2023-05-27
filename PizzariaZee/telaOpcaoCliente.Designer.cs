namespace PizzariaZee
{
    partial class telaOpcaoCliente
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
            btnCadastroCliente = new Button();
            btnVisualizarCliente = new Button();
            SuspendLayout();
            // 
            // btnCadastroCliente
            // 
            btnCadastroCliente.Location = new Point(81, 40);
            btnCadastroCliente.Name = "btnCadastroCliente";
            btnCadastroCliente.Size = new Size(181, 67);
            btnCadastroCliente.TabIndex = 0;
            btnCadastroCliente.Text = "Cadastrar cliente";
            btnCadastroCliente.UseVisualStyleBackColor = true;
            btnCadastroCliente.Click += button1_Click;
            // 
            // btnVisualizarCliente
            // 
            btnVisualizarCliente.Location = new Point(81, 151);
            btnVisualizarCliente.Name = "btnVisualizarCliente";
            btnVisualizarCliente.Size = new Size(187, 62);
            btnVisualizarCliente.TabIndex = 1;
            btnVisualizarCliente.Text = "Visualizar cliente";
            btnVisualizarCliente.UseVisualStyleBackColor = true;
            btnVisualizarCliente.Click += btnVisualizarCliente_Click;
            // 
            // telaOpcaoCliente
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(372, 267);
            Controls.Add(btnVisualizarCliente);
            Controls.Add(btnCadastroCliente);
            Name = "telaOpcaoCliente";
            Text = "telaOpcaoCliente";
            ResumeLayout(false);
        }

        #endregion

        private Button btnCadastroCliente;
        private Button btnVisualizarCliente;
    }
}