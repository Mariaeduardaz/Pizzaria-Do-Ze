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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemAdministradorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pizzaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bebidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fornecedorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCadastroPizza
            // 
            this.BtnCadastroPizza.Location = new System.Drawing.Point(13, 65);
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
            this.BtnCadastroPedido.Location = new System.Drawing.Point(338, 65);
            this.BtnCadastroPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCadastroPedido.Name = "BtnCadastroPedido";
            this.BtnCadastroPedido.Size = new System.Drawing.Size(283, 42);
            this.BtnCadastroPedido.TabIndex = 3;
            this.BtnCadastroPedido.Text = "Cadastro Pedido";
            this.BtnCadastroPedido.UseVisualStyleBackColor = true;
            this.BtnCadastroPedido.Click += new System.EventHandler(this.pedidoBtn_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(471, 179);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(136, 36);
            this.btnVoltar.TabIndex = 5;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // BtnCadastroFuncionario
            // 
            this.BtnCadastroFuncionario.Location = new System.Drawing.Point(13, 118);
            this.BtnCadastroFuncionario.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnCadastroFuncionario.Name = "BtnCadastroFuncionario";
            this.BtnCadastroFuncionario.Size = new System.Drawing.Size(283, 40);
            this.BtnCadastroFuncionario.TabIndex = 1;
            this.BtnCadastroFuncionario.Text = "Cadastro Funcionario";
            this.BtnCadastroFuncionario.UseVisualStyleBackColor = true;
            this.BtnCadastroFuncionario.Click += new System.EventHandler(this.cadastroFuncionarioBtn_Click);
            // 
            // BtnCadastroFornecedor
            // 
            this.BtnCadastroFornecedor.Location = new System.Drawing.Point(12, 166);
            this.BtnCadastroFornecedor.Name = "BtnCadastroFornecedor";
            this.BtnCadastroFornecedor.Size = new System.Drawing.Size(283, 40);
            this.BtnCadastroFornecedor.TabIndex = 2;
            this.BtnCadastroFornecedor.Text = "Cadastro Fornecedor";
            this.BtnCadastroFornecedor.UseVisualStyleBackColor = true;
            this.BtnCadastroFornecedor.Click += new System.EventHandler(this.BtnFornecedor_Click);
            // 
            // BtnCadastroBebida
            // 
            this.BtnCadastroBebida.Location = new System.Drawing.Point(338, 118);
            this.BtnCadastroBebida.Name = "BtnCadastroBebida";
            this.BtnCadastroBebida.Size = new System.Drawing.Size(283, 40);
            this.BtnCadastroBebida.TabIndex = 4;
            this.BtnCadastroBebida.Text = "Cadastro Bebidas";
            this.BtnCadastroBebida.UseVisualStyleBackColor = true;
            this.BtnCadastroBebida.Click += new System.EventHandler(this.bntBebida_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAdministradorToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(666, 33);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemAdministradorToolStripMenuItem
            // 
            this.itemAdministradorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pizzaToolStripMenuItem,
            this.funcionarioToolStripMenuItem,
            this.pedidoToolStripMenuItem,
            this.bebidaToolStripMenuItem,
            this.fornecedorToolStripMenuItem,
            this.toolStripSeparator1,
            this.sairToolStripMenuItem});
            this.itemAdministradorToolStripMenuItem.Name = "itemAdministradorToolStripMenuItem";
            this.itemAdministradorToolStripMenuItem.Size = new System.Drawing.Size(183, 29);
            this.itemAdministradorToolStripMenuItem.Text = "Item Administrador";
            // 
            // pizzaToolStripMenuItem
            // 
            this.pizzaToolStripMenuItem.Name = "pizzaToolStripMenuItem";
            this.pizzaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
            this.pizzaToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.pizzaToolStripMenuItem.Text = "Pizza";
            // 
            // funcionarioToolStripMenuItem
            // 
            this.funcionarioToolStripMenuItem.Name = "funcionarioToolStripMenuItem";
            this.funcionarioToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
            this.funcionarioToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.funcionarioToolStripMenuItem.Text = "Funcionario";
            // 
            // pedidoToolStripMenuItem
            // 
            this.pedidoToolStripMenuItem.Name = "pedidoToolStripMenuItem";
            this.pedidoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
            this.pedidoToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.pedidoToolStripMenuItem.Text = "Pedido";
            // 
            // bebidaToolStripMenuItem
            // 
            this.bebidaToolStripMenuItem.Name = "bebidaToolStripMenuItem";
            this.bebidaToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
            this.bebidaToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.bebidaToolStripMenuItem.Text = "Bebida";
            // 
            // fornecedorToolStripMenuItem
            // 
            this.fornecedorToolStripMenuItem.Name = "fornecedorToolStripMenuItem";
            this.fornecedorToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
            this.fornecedorToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.fornecedorToolStripMenuItem.Text = "Fornecedor";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(285, 34);
            this.sairToolStripMenuItem.Text = "Sair";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(282, 6);
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
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipalAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal Administrador";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnCadastroPizza;
        private System.Windows.Forms.Button BtnCadastroPedido;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button BtnCadastroFuncionario;
        private System.Windows.Forms.Button BtnCadastroFornecedor;
        private System.Windows.Forms.Button BtnCadastroBebida;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemAdministradorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pizzaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem funcionarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bebidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fornecedorToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
    }
}