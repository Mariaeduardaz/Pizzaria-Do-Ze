namespace Pizzaria_Do_Ze.Telas_Pedido
{
    partial class TelaAcessarStatusPedidoAtendente
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
            this.labelID = new System.Windows.Forms.Label();
            this.idPedidosAbertoscomboBox = new System.Windows.Forms.ComboBox();
            this.btnFechar = new System.Windows.Forms.Button();
            this.acessarBtn = new System.Windows.Forms.Button();
            this.labelNome = new System.Windows.Forms.Label();
            this.textBoxnome = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(110, 108);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(30, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID:";
            // 
            // idPedidosAbertoscomboBox
            // 
            this.idPedidosAbertoscomboBox.FormattingEnabled = true;
            this.idPedidosAbertoscomboBox.Location = new System.Drawing.Point(148, 100);
            this.idPedidosAbertoscomboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.idPedidosAbertoscomboBox.Name = "idPedidosAbertoscomboBox";
            this.idPedidosAbertoscomboBox.Size = new System.Drawing.Size(180, 28);
            this.idPedidosAbertoscomboBox.TabIndex = 1;
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(376, 155);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(112, 35);
            this.btnFechar.TabIndex = 3;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // acessarBtn
            // 
            this.acessarBtn.Location = new System.Drawing.Point(336, 96);
            this.acessarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.acessarBtn.Name = "acessarBtn";
            this.acessarBtn.Size = new System.Drawing.Size(112, 35);
            this.acessarBtn.TabIndex = 2;
            this.acessarBtn.Text = "Acessar";
            this.acessarBtn.UseVisualStyleBackColor = true;
            this.acessarBtn.Click += new System.EventHandler(this.acessarBtn_Click);
            // 
            // labelNome
            // 
            this.labelNome.AutoSize = true;
            this.labelNome.Location = new System.Drawing.Point(85, 62);
            this.labelNome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNome.Name = "labelNome";
            this.labelNome.Size = new System.Drawing.Size(55, 20);
            this.labelNome.TabIndex = 4;
            this.labelNome.Text = "Nome:";
            // 
            // textBoxnome
            // 
            this.textBoxnome.Location = new System.Drawing.Point(147, 62);
            this.textBoxnome.Name = "textBoxnome";
            this.textBoxnome.Size = new System.Drawing.Size(170, 26);
            this.textBoxnome.TabIndex = 0;
            // 
            // TelaAcessarStatusPedidoAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(501, 211);
            this.Controls.Add(this.textBoxnome);
            this.Controls.Add(this.labelNome);
            this.Controls.Add(this.acessarBtn);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.idPedidosAbertoscomboBox);
            this.Controls.Add(this.labelID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaAcessarStatusPedidoAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acessar Status Atendente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button acessarBtn;
        private System.Windows.Forms.Label labelNome;
        private System.Windows.Forms.TextBox textBoxnome;
        private System.Windows.Forms.ComboBox idPedidosAbertoscomboBox;
    }
}