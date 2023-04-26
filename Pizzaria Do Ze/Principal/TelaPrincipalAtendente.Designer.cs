namespace Pizzaria_Do_Ze
{
    partial class TelaPrincipalAtendente
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
            this.clienteBtn = new System.Windows.Forms.Button();
            this.BtnVisPedido = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.BtnEditarStatusPedid = new System.Windows.Forms.Button();
            this.btnEditarCliente = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.itemAtendenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarPedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SairStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // clienteBtn
            // 
            this.clienteBtn.Location = new System.Drawing.Point(26, 75);
            this.clienteBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.clienteBtn.Name = "clienteBtn";
            this.clienteBtn.Size = new System.Drawing.Size(202, 37);
            this.clienteBtn.TabIndex = 0;
            this.clienteBtn.Text = "Cliente";
            this.clienteBtn.UseVisualStyleBackColor = true;
            this.clienteBtn.Click += new System.EventHandler(this.clienteBtn_Click);
            // 
            // BtnVisPedido
            // 
            this.BtnVisPedido.Location = new System.Drawing.Point(26, 169);
            this.BtnVisPedido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnVisPedido.Name = "BtnVisPedido";
            this.BtnVisPedido.Size = new System.Drawing.Size(202, 39);
            this.BtnVisPedido.TabIndex = 2;
            this.BtnVisPedido.Text = "Visualizar Pedidos";
            this.BtnVisPedido.UseVisualStyleBackColor = true;
            this.BtnVisPedido.Click += new System.EventHandler(this.visPedidoBtn_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(154, 283);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 32);
            this.btnVoltar.TabIndex = 4;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // BtnEditarStatusPedid
            // 
            this.BtnEditarStatusPedid.Location = new System.Drawing.Point(26, 218);
            this.BtnEditarStatusPedid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditarStatusPedid.Name = "BtnEditarStatusPedid";
            this.BtnEditarStatusPedid.Size = new System.Drawing.Size(202, 40);
            this.BtnEditarStatusPedid.TabIndex = 3;
            this.BtnEditarStatusPedid.Text = "Editar Status Pedidos";
            this.BtnEditarStatusPedid.UseVisualStyleBackColor = true;
            this.BtnEditarStatusPedid.Click += new System.EventHandler(this.editarStatusPedidoBtn_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(26, 122);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(202, 37);
            this.btnEditarCliente.TabIndex = 1;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.itemAtendenteToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(262, 33);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // itemAtendenteToolStripMenuItem
            // 
            this.itemAtendenteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.toolStripSeparator1,
            this.SairStripMenuItem1});
            this.itemAtendenteToolStripMenuItem.Name = "itemAtendenteToolStripMenuItem";
            this.itemAtendenteToolStripMenuItem.Size = new System.Drawing.Size(148, 29);
            this.itemAtendenteToolStripMenuItem.Text = "Item atendente";
            // 
            // clienteToolStripMenuItem
            // 
            this.clienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarClienteToolStripMenuItem});
            this.clienteToolStripMenuItem.Name = "clienteToolStripMenuItem";
            this.clienteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F10)));
            this.clienteToolStripMenuItem.Size = new System.Drawing.Size(356, 34);
            this.clienteToolStripMenuItem.Text = "Cliente";
            // 
            // editarClienteToolStripMenuItem
            // 
            this.editarClienteToolStripMenuItem.Name = "editarClienteToolStripMenuItem";
            this.editarClienteToolStripMenuItem.Size = new System.Drawing.Size(217, 34);
            this.editarClienteToolStripMenuItem.Text = "Editar Cliente";
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editarPedidosToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F11)));
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(356, 34);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // editarPedidosToolStripMenuItem
            // 
            this.editarPedidosToolStripMenuItem.Name = "editarPedidosToolStripMenuItem";
            this.editarPedidosToolStripMenuItem.Size = new System.Drawing.Size(227, 34);
            this.editarPedidosToolStripMenuItem.Text = "Editar Pedidos";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(353, 6);
            // 
            // SairStripMenuItem1
            // 
            this.SairStripMenuItem1.Name = "SairStripMenuItem1";
            this.SairStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.Delete)));
            this.SairStripMenuItem1.Size = new System.Drawing.Size(356, 34);
            this.SairStripMenuItem1.Text = "SairStripMenuItem1";
            // 
            // TelaPrincipalAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(262, 326);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.BtnEditarStatusPedid);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.BtnVisPedido);
            this.Controls.Add(this.clienteBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipalAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal Atendente";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button clienteBtn;
        private System.Windows.Forms.Button BtnVisPedido;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button BtnEditarStatusPedid;
        private System.Windows.Forms.Button btnEditarCliente;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem itemAtendenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarPedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem SairStripMenuItem1;
    }
}