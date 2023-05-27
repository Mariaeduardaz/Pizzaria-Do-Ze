namespace PizzariaZee
{
    partial class TelaPedidosPendentes
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
            this.ListBoxPedidoPendente = new System.Windows.Forms.ListBox();
            this.abrirPedidoBtn = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.labelQuantidadePedidoPendente = new System.Windows.Forms.Label();
            this.labelPedidoPendente = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ListBoxPedidoPendente
            // 
            this.ListBoxPedidoPendente.FormattingEnabled = true;
            this.ListBoxPedidoPendente.ItemHeight = 20;
            this.ListBoxPedidoPendente.Location = new System.Drawing.Point(18, 52);
            this.ListBoxPedidoPendente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ListBoxPedidoPendente.Name = "ListBoxPedidoPendente";
            this.ListBoxPedidoPendente.Size = new System.Drawing.Size(423, 484);
            this.ListBoxPedidoPendente.TabIndex = 0;
            // 
            // abrirPedidoBtn
            // 
            this.abrirPedidoBtn.Location = new System.Drawing.Point(239, 479);
            this.abrirPedidoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.abrirPedidoBtn.Name = "abrirPedidoBtn";
            this.abrirPedidoBtn.Size = new System.Drawing.Size(202, 57);
            this.abrirPedidoBtn.TabIndex = 1;
            this.abrirPedidoBtn.Text = "Abrir pedido";
            this.abrirPedidoBtn.UseVisualStyleBackColor = true;
            this.abrirPedidoBtn.Click += new System.EventHandler(this.abrirPedidoBtn_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(349, 546);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(147, 43);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelQuantidadePedidoPendente
            // 
            this.labelQuantidadePedidoPendente.AutoSize = true;
            this.labelQuantidadePedidoPendente.Location = new System.Drawing.Point(18, 546);
            this.labelQuantidadePedidoPendente.Name = "labelQuantidadePedidoPendente";
            this.labelQuantidadePedidoPendente.Size = new System.Drawing.Size(205, 20);
            this.labelQuantidadePedidoPendente.TabIndex = 2;
            this.labelQuantidadePedidoPendente.Text = "10 pedidos pendentes hoje.";
            // 
            // labelPedidoPendente
            // 
            this.labelPedidoPendente.AutoSize = true;
            this.labelPedidoPendente.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedidoPendente.Location = new System.Drawing.Point(18, 9);
            this.labelPedidoPendente.Name = "labelPedidoPendente";
            this.labelPedidoPendente.Size = new System.Drawing.Size(85, 24);
            this.labelPedidoPendente.TabIndex = 4;
            this.labelPedidoPendente.Text = "Pedidos";
            // 
            // TelaPedidosPendentes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(495, 593);
            this.Controls.Add(this.labelPedidoPendente);
            this.Controls.Add(this.labelQuantidadePedidoPendente);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.abrirPedidoBtn);
            this.Controls.Add(this.ListBoxPedidoPendente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPedidosPendentes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PedidosPendentes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListBoxPedidoPendente;
        private System.Windows.Forms.Button abrirPedidoBtn;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label labelQuantidadePedidoPendente;
        private System.Windows.Forms.Label labelPedidoPendente;
    }
}