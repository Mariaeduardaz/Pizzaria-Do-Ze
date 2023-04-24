namespace Pizzaria_Do_Ze
{
    partial class TelaPrincipalAdmin
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
            this.BtnCadastroPizza = new System.Windows.Forms.Button();
            this.BtnCadastroPedido = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.BtnCadastroFuncionario = new System.Windows.Forms.Button();
            this.BtnCadastroFornecedor = new System.Windows.Forms.Button();
            this.BtnCadastroBebida = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnCadastroPizza
            // 
            this.BtnCadastroPizza.Location = new System.Drawing.Point(13, 44);
            this.BtnCadastroPizza.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCadastroPizza.Name = "BtnCadastroPizza";
            this.BtnCadastroPizza.Size = new System.Drawing.Size(283, 43);
            this.BtnCadastroPizza.TabIndex = 0;
            this.BtnCadastroPizza.Text = "Cadastro Pizza";
            this.BtnCadastroPizza.UseVisualStyleBackColor = true;
            this.BtnCadastroPizza.Click += new System.EventHandler(this.pizzaBtn_Click);
            // 
            // BtnCadastroPedido
            // 
            this.BtnCadastroPedido.Location = new System.Drawing.Point(338, 44);
            this.BtnCadastroPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCadastroPedido.Name = "BtnCadastroPedido";
            this.BtnCadastroPedido.Size = new System.Drawing.Size(283, 42);
            this.BtnCadastroPedido.TabIndex = 5;
            this.BtnCadastroPedido.Text = "Cadastro Pedido";
            this.BtnCadastroPedido.UseVisualStyleBackColor = true;
            this.BtnCadastroPedido.Click += new System.EventHandler(this.pedidoBtn_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(451, 150);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(136, 36);
            this.btnVoltar.TabIndex = 8;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // BtnCadastroFuncionario
            // 
            this.BtnCadastroFuncionario.Location = new System.Drawing.Point(13, 102);
            this.BtnCadastroFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCadastroFuncionario.Name = "BtnCadastroFuncionario";
            this.BtnCadastroFuncionario.Size = new System.Drawing.Size(283, 40);
            this.BtnCadastroFuncionario.TabIndex = 10;
            this.BtnCadastroFuncionario.Text = "Cadastro Funcionario";
            this.BtnCadastroFuncionario.UseVisualStyleBackColor = true;
            this.BtnCadastroFuncionario.Click += new System.EventHandler(this.cadastroFuncionarioBtn_Click);
            // 
            // BtnCadastroFornecedor
            // 
            this.BtnCadastroFornecedor.Location = new System.Drawing.Point(12, 160);
            this.BtnCadastroFornecedor.Name = "BtnCadastroFornecedor";
            this.BtnCadastroFornecedor.Size = new System.Drawing.Size(283, 40);
            this.BtnCadastroFornecedor.TabIndex = 12;
            this.BtnCadastroFornecedor.Text = "Cadastro Fornecedor";
            this.BtnCadastroFornecedor.UseVisualStyleBackColor = true;
            this.BtnCadastroFornecedor.Click += new System.EventHandler(this.BtnFornecedor_Click);
            // 
            // BtnCadastroBebida
            // 
            this.BtnCadastroBebida.Location = new System.Drawing.Point(338, 94);
            this.BtnCadastroBebida.Name = "BtnCadastroBebida";
            this.BtnCadastroBebida.Size = new System.Drawing.Size(283, 40);
            this.BtnCadastroBebida.TabIndex = 13;
            this.BtnCadastroBebida.Text = "Cadastro Bebidas";
            this.BtnCadastroBebida.UseVisualStyleBackColor = true;
            this.BtnCadastroBebida.Click += new System.EventHandler(this.bntBebida_Click);
            // 
            // TelaPrincipalAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(666, 243);
            this.Controls.Add(this.BtnCadastroBebida);
            this.Controls.Add(this.BtnCadastroFornecedor);
            this.Controls.Add(this.BtnCadastroFuncionario);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.BtnCadastroPedido);
            this.Controls.Add(this.BtnCadastroPizza);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastroPizza;
        private System.Windows.Forms.Button BtnCadastroPedido;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button BtnCadastroFuncionario;
        private System.Windows.Forms.Button BtnCadastroFornecedor;
        private System.Windows.Forms.Button BtnCadastroBebida;
    }
}