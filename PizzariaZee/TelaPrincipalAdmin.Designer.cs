namespace PizzariaZee
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
            BtnCadastroPizza = new Button();
            BtnCadastroPedido = new Button();
            btnVoltar = new Button();
            BtnCadastroFuncionario = new Button();
            BtnCadastroFornecedor = new Button();
            BtnCadastroBebida = new Button();
            menuStrip1 = new MenuStrip();
            itemAdministradorToolStripMenuItem = new ToolStripMenuItem();
            pizzaToolStripMenuItem = new ToolStripMenuItem();
            funcionarioToolStripMenuItem = new ToolStripMenuItem();
            pedidoToolStripMenuItem = new ToolStripMenuItem();
            bebidaToolStripMenuItem = new ToolStripMenuItem();
            fornecedorToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            sairToolStripMenuItem = new ToolStripMenuItem();
            buttonEndereco = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCadastroPizza
            // 
            BtnCadastroPizza.Location = new Point(14, 81);
            BtnCadastroPizza.Margin = new Padding(4, 6, 4, 6);
            BtnCadastroPizza.Name = "BtnCadastroPizza";
            BtnCadastroPizza.Size = new Size(314, 54);
            BtnCadastroPizza.TabIndex = 0;
            BtnCadastroPizza.Text = "Cadastro Pizza";
            BtnCadastroPizza.UseVisualStyleBackColor = true;
            BtnCadastroPizza.Click += pizzaBtn_Click;
            // 
            // BtnCadastroPedido
            // 
            BtnCadastroPedido.Location = new Point(376, 81);
            BtnCadastroPedido.Margin = new Padding(4, 6, 4, 6);
            BtnCadastroPedido.Name = "BtnCadastroPedido";
            BtnCadastroPedido.Size = new Size(314, 52);
            BtnCadastroPedido.TabIndex = 3;
            BtnCadastroPedido.Text = "Cliente";
            BtnCadastroPedido.UseVisualStyleBackColor = true;
            BtnCadastroPedido.Click += pedidoBtn_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(563, 307);
            btnVoltar.Margin = new Padding(4, 6, 4, 6);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(151, 45);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += voltarBtn_Click;
            // 
            // BtnCadastroFuncionario
            // 
            BtnCadastroFuncionario.Location = new Point(14, 148);
            BtnCadastroFuncionario.Margin = new Padding(4, 6, 4, 6);
            BtnCadastroFuncionario.Name = "BtnCadastroFuncionario";
            BtnCadastroFuncionario.Size = new Size(314, 50);
            BtnCadastroFuncionario.TabIndex = 1;
            BtnCadastroFuncionario.Text = "Funcionario";
            BtnCadastroFuncionario.UseVisualStyleBackColor = true;
            BtnCadastroFuncionario.Click += cadastroFuncionarioBtn_Click;
            // 
            // BtnCadastroFornecedor
            // 
            BtnCadastroFornecedor.Location = new Point(13, 208);
            BtnCadastroFornecedor.Margin = new Padding(3, 4, 3, 4);
            BtnCadastroFornecedor.Name = "BtnCadastroFornecedor";
            BtnCadastroFornecedor.Size = new Size(314, 50);
            BtnCadastroFornecedor.TabIndex = 2;
            BtnCadastroFornecedor.Text = "Cadastro Fornecedor";
            BtnCadastroFornecedor.UseVisualStyleBackColor = true;
            BtnCadastroFornecedor.Click += BtnFornecedor_Click;
            // 
            // BtnCadastroBebida
            // 
            BtnCadastroBebida.Location = new Point(376, 148);
            BtnCadastroBebida.Margin = new Padding(3, 4, 3, 4);
            BtnCadastroBebida.Name = "BtnCadastroBebida";
            BtnCadastroBebida.Size = new Size(314, 50);
            BtnCadastroBebida.TabIndex = 4;
            BtnCadastroBebida.Text = "Cadastro Bebidas";
            BtnCadastroBebida.UseVisualStyleBackColor = true;
            BtnCadastroBebida.Click += bntBebida_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { itemAdministradorToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(777, 33);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // itemAdministradorToolStripMenuItem
            // 
            itemAdministradorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pizzaToolStripMenuItem, funcionarioToolStripMenuItem, pedidoToolStripMenuItem, bebidaToolStripMenuItem, fornecedorToolStripMenuItem, toolStripSeparator1, sairToolStripMenuItem });
            itemAdministradorToolStripMenuItem.Name = "itemAdministradorToolStripMenuItem";
            itemAdministradorToolStripMenuItem.Size = new Size(183, 29);
            itemAdministradorToolStripMenuItem.Text = "Item Administrador";
            // 
            // pizzaToolStripMenuItem
            // 
            pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            pizzaToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F1;
            pizzaToolStripMenuItem.Size = new Size(285, 34);
            pizzaToolStripMenuItem.Text = "Pizza";
            // 
            // funcionarioToolStripMenuItem
            // 
            funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            funcionarioToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F2;
            funcionarioToolStripMenuItem.Size = new Size(285, 34);
            funcionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            pedidoToolStripMenuItem.Size = new Size(285, 34);
            pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // bebidaToolStripMenuItem
            // 
            bebidaToolStripMenuItem.Name = "bebidaToolStripMenuItem";
            bebidaToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F4;
            bebidaToolStripMenuItem.Size = new Size(285, 34);
            bebidaToolStripMenuItem.Text = "Bebida";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
            fornecedorToolStripMenuItem.Size = new Size(285, 34);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(282, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.Delete;
            sairToolStripMenuItem.Size = new Size(285, 34);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // buttonEndereco
            // 
            buttonEndereco.Location = new Point(376, 208);
            buttonEndereco.Margin = new Padding(3, 4, 3, 4);
            buttonEndereco.Name = "buttonEndereco";
            buttonEndereco.Size = new Size(314, 50);
            buttonEndereco.TabIndex = 7;
            buttonEndereco.Text = "Endereços cadastrados";
            buttonEndereco.UseVisualStyleBackColor = true;
            buttonEndereco.Click += buttonEndereco_Click;
            // 
            // TelaPrincipalAdmin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(777, 380);
            Controls.Add(buttonEndereco);
            Controls.Add(BtnCadastroBebida);
            Controls.Add(BtnCadastroFornecedor);
            Controls.Add(BtnCadastroFuncionario);
            Controls.Add(btnVoltar);
            Controls.Add(BtnCadastroPedido);
            Controls.Add(BtnCadastroPizza);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 6, 4, 6);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TelaPrincipalAdmin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Principal Administrador";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BtnCadastroPizza;
        private Button BtnCadastroPedido;
        private Button btnVoltar;
        private Button BtnCadastroFuncionario;
        private Button BtnCadastroFornecedor;
        private Button BtnCadastroBebida;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem itemAdministradorToolStripMenuItem;
        private ToolStripMenuItem pizzaToolStripMenuItem;
        private ToolStripMenuItem funcionarioToolStripMenuItem;
        private ToolStripMenuItem pedidoToolStripMenuItem;
        private ToolStripMenuItem bebidaToolStripMenuItem;
        private ToolStripMenuItem fornecedorToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private Button buttonEndereco;
    }
}