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
            this.SuspendLayout();
            // 
            // clienteBtn
            // 
            this.clienteBtn.Location = new System.Drawing.Point(73, 30);
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
            this.BtnVisPedido.Location = new System.Drawing.Point(73, 124);
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
            this.btnVoltar.Location = new System.Drawing.Point(264, 223);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(95, 32);
            this.btnVoltar.TabIndex = 3;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // BtnEditarStatusPedid
            // 
            this.BtnEditarStatusPedid.Location = new System.Drawing.Point(73, 173);
            this.BtnEditarStatusPedid.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnEditarStatusPedid.Name = "BtnEditarStatusPedid";
            this.BtnEditarStatusPedid.Size = new System.Drawing.Size(202, 40);
            this.BtnEditarStatusPedid.TabIndex = 4;
            this.BtnEditarStatusPedid.Text = "Editar Status Pedidos";
            this.BtnEditarStatusPedid.UseVisualStyleBackColor = true;
            this.BtnEditarStatusPedid.Click += new System.EventHandler(this.editarStatusPedidoBtn_Click);
            // 
            // btnEditarCliente
            // 
            this.btnEditarCliente.Location = new System.Drawing.Point(73, 77);
            this.btnEditarCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEditarCliente.Name = "btnEditarCliente";
            this.btnEditarCliente.Size = new System.Drawing.Size(202, 37);
            this.btnEditarCliente.TabIndex = 5;
            this.btnEditarCliente.Text = "Editar Cliente";
            this.btnEditarCliente.UseVisualStyleBackColor = true;
            // 
            // TelaPrincipalAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(365, 262);
            this.Controls.Add(this.btnEditarCliente);
            this.Controls.Add(this.BtnEditarStatusPedid);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.BtnVisPedido);
            this.Controls.Add(this.clienteBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipalAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal Atendente";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button clienteBtn;
        private System.Windows.Forms.Button BtnVisPedido;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button BtnEditarStatusPedid;
        private System.Windows.Forms.Button btnEditarCliente;
    }
}