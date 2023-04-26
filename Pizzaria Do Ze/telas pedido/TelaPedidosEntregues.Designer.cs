namespace Pizzaria_Do_Ze.Telas_Pedido
{
    partial class TelaPedidosEntregues
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
            this.pedidosEntregues = new System.Windows.Forms.ListBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.abrirPedidoBtn = new System.Windows.Forms.Button();
            this.labelPedidosEntregues = new System.Windows.Forms.Label();
            this.labelNumeroPedidosEntregues = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pedidosEntregues
            // 
            this.pedidosEntregues.FormattingEnabled = true;
            this.pedidosEntregues.ItemHeight = 20;
            this.pedidosEntregues.Location = new System.Drawing.Point(13, 65);
            this.pedidosEntregues.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pedidosEntregues.Name = "pedidosEntregues";
            this.pedidosEntregues.Size = new System.Drawing.Size(435, 424);
            this.pedidosEntregues.TabIndex = 0;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(360, 499);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(117, 38);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // abrirPedidoBtn
            // 
            this.abrirPedidoBtn.Location = new System.Drawing.Point(246, 432);
            this.abrirPedidoBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.abrirPedidoBtn.Name = "abrirPedidoBtn";
            this.abrirPedidoBtn.Size = new System.Drawing.Size(202, 57);
            this.abrirPedidoBtn.TabIndex = 1;
            this.abrirPedidoBtn.Text = "Abrir pedido";
            this.abrirPedidoBtn.UseVisualStyleBackColor = true;
            this.abrirPedidoBtn.Click += new System.EventHandler(this.abrirPedidoBtn_Click);
            // 
            // labelPedidosEntregues
            // 
            this.labelPedidosEntregues.AutoSize = true;
            this.labelPedidosEntregues.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPedidosEntregues.Location = new System.Drawing.Point(12, 18);
            this.labelPedidosEntregues.Name = "labelPedidosEntregues";
            this.labelPedidosEntregues.Size = new System.Drawing.Size(91, 24);
            this.labelPedidosEntregues.TabIndex = 5;
            this.labelPedidosEntregues.Text = "Pedidos:";
            // 
            // labelNumeroPedidosEntregues
            // 
            this.labelNumeroPedidosEntregues.AutoSize = true;
            this.labelNumeroPedidosEntregues.Font = new System.Drawing.Font("Imprint MT Shadow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumeroPedidosEntregues.Location = new System.Drawing.Point(12, 494);
            this.labelNumeroPedidosEntregues.Name = "labelNumeroPedidosEntregues";
            this.labelNumeroPedidosEntregues.Size = new System.Drawing.Size(251, 24);
            this.labelNumeroPedidosEntregues.TabIndex = 2;
            this.labelNumeroPedidosEntregues.Text = "23 pedidos entregues hoje";
            // 
            // TelaPedidosEntregues
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(486, 541);
            this.Controls.Add(this.labelNumeroPedidosEntregues);
            this.Controls.Add(this.labelPedidosEntregues);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.abrirPedidoBtn);
            this.Controls.Add(this.pedidosEntregues);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPedidosEntregues";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedidos Entregues";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox pedidosEntregues;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button abrirPedidoBtn;
        private System.Windows.Forms.Label labelPedidosEntregues;
        private System.Windows.Forms.Label labelNumeroPedidosEntregues;
    }
}