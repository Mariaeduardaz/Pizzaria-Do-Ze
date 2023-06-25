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
            buttonPedido = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // BtnCadastroPizza
            // 
            BtnCadastroPizza.Location = new Point(11, 65);
            BtnCadastroPizza.Margin = new Padding(3, 5, 3, 5);
            BtnCadastroPizza.Name = "BtnCadastroPizza";
            BtnCadastroPizza.Size = new Size(251, 43);
            BtnCadastroPizza.TabIndex = 0;
            BtnCadastroPizza.Text = "Cadastro Pizza";
            BtnCadastroPizza.UseVisualStyleBackColor = true;
            BtnCadastroPizza.Click += pizzaBtn_Click;
            // 
            // BtnCadastroPedido
            // 
            BtnCadastroPedido.Location = new Point(301, 65);
            BtnCadastroPedido.Margin = new Padding(3, 5, 3, 5);
            BtnCadastroPedido.Name = "BtnCadastroPedido";
            BtnCadastroPedido.Size = new Size(251, 42);
            BtnCadastroPedido.TabIndex = 3;
            BtnCadastroPedido.Text = "Cliente";
            BtnCadastroPedido.UseVisualStyleBackColor = true;
            BtnCadastroPedido.Click += pedidoBtn_Click;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(450, 246);
            btnVoltar.Margin = new Padding(3, 5, 3, 5);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(121, 36);
            btnVoltar.TabIndex = 5;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            btnVoltar.Click += voltarBtn_Click;
            // 
            // BtnCadastroFuncionario
            // 
            BtnCadastroFuncionario.Location = new Point(11, 118);
            BtnCadastroFuncionario.Margin = new Padding(3, 5, 3, 5);
            BtnCadastroFuncionario.Name = "BtnCadastroFuncionario";
            BtnCadastroFuncionario.Size = new Size(251, 40);
            BtnCadastroFuncionario.TabIndex = 1;
            BtnCadastroFuncionario.Text = "Funcionario";
            BtnCadastroFuncionario.UseVisualStyleBackColor = true;
            BtnCadastroFuncionario.Click += cadastroFuncionarioBtn_Click;
            // 
            // BtnCadastroFornecedor
            // 
            BtnCadastroFornecedor.Location = new Point(10, 166);
            BtnCadastroFornecedor.Margin = new Padding(2, 3, 2, 3);
            BtnCadastroFornecedor.Name = "BtnCadastroFornecedor";
            BtnCadastroFornecedor.Size = new Size(251, 40);
            BtnCadastroFornecedor.TabIndex = 2;
            BtnCadastroFornecedor.Text = "Cadastro Fornecedor";
            BtnCadastroFornecedor.UseVisualStyleBackColor = true;
            BtnCadastroFornecedor.Click += BtnFornecedor_Click;
            // 
            // BtnCadastroBebida
            // 
            BtnCadastroBebida.Location = new Point(301, 118);
            BtnCadastroBebida.Margin = new Padding(2, 3, 2, 3);
            BtnCadastroBebida.Name = "BtnCadastroBebida";
            BtnCadastroBebida.Size = new Size(251, 40);
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
            menuStrip1.Size = new Size(622, 28);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // itemAdministradorToolStripMenuItem
            // 
            itemAdministradorToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { pizzaToolStripMenuItem, funcionarioToolStripMenuItem, pedidoToolStripMenuItem, bebidaToolStripMenuItem, fornecedorToolStripMenuItem, toolStripSeparator1, sairToolStripMenuItem });
            itemAdministradorToolStripMenuItem.Name = "itemAdministradorToolStripMenuItem";
            itemAdministradorToolStripMenuItem.Size = new Size(152, 24);
            itemAdministradorToolStripMenuItem.Text = "Item Administrador";
            // 
            // pizzaToolStripMenuItem
            // 
            pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            pizzaToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F1;
            pizzaToolStripMenuItem.Size = new Size(233, 26);
            pizzaToolStripMenuItem.Text = "Pizza";
            // 
            // funcionarioToolStripMenuItem
            // 
            funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            funcionarioToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F2;
            funcionarioToolStripMenuItem.Size = new Size(233, 26);
            funcionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // pedidoToolStripMenuItem
            // 
            pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            pedidoToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F3;
            pedidoToolStripMenuItem.Size = new Size(233, 26);
            pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // bebidaToolStripMenuItem
            // 
            bebidaToolStripMenuItem.Name = "bebidaToolStripMenuItem";
            bebidaToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F4;
            bebidaToolStripMenuItem.Size = new Size(233, 26);
            bebidaToolStripMenuItem.Text = "Bebida";
            // 
            // fornecedorToolStripMenuItem
            // 
            fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            fornecedorToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.F5;
            fornecedorToolStripMenuItem.Size = new Size(233, 26);
            fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(230, 6);
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.ShortcutKeys = Keys.Shift | Keys.Delete;
            sairToolStripMenuItem.Size = new Size(233, 26);
            sairToolStripMenuItem.Text = "Sair";
            // 
            // buttonEndereco
            // 
            buttonEndereco.Location = new Point(301, 166);
            buttonEndereco.Margin = new Padding(2, 3, 2, 3);
            buttonEndereco.Name = "buttonEndereco";
            buttonEndereco.Size = new Size(251, 40);
            buttonEndereco.TabIndex = 7;
            buttonEndereco.Text = "Endereços cadastrados";
            buttonEndereco.UseVisualStyleBackColor = true;
            buttonEndereco.Click += buttonEndereco_Click;
            // 
            // buttonPedido
            // 
            buttonPedido.Location = new Point(11, 212);
            buttonPedido.Margin = new Padding(2, 3, 2, 3);
            buttonPedido.Name = "buttonPedido";
            buttonPedido.Size = new Size(251, 40);
            buttonPedido.TabIndex = 8;
            buttonPedido.Text = "Pedido";
            buttonPedido.UseVisualStyleBackColor = true;
            buttonPedido.Click += buttonPedido_Click;
            // 
            // TelaPrincipalAdmin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 192);
            ClientSize = new Size(622, 304);
            Controls.Add(buttonPedido);
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
            Margin = new Padding(3, 5, 3, 5);
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
        private Button buttonPedido;
    }
}