namespace PizzariadoZe.Telas_Pedido
{
    partial class TelaStatusPedidoAtendente
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
            this.labelStatusPagamento = new System.Windows.Forms.Label();
            this.labelStatusPedido = new System.Windows.Forms.Label();
            this.pagoRadioBtn = new System.Windows.Forms.RadioButton();
            this.pendenteRadioBtn = new System.Windows.Forms.RadioButton();
            this.preparoRadioBtn = new System.Windows.Forms.RadioButton();
            this.RetiradaRadioBtn = new System.Windows.Forms.RadioButton();
            this.SaiuRadioBtn = new System.Windows.Forms.RadioButton();
            this.btnFechar = new System.Windows.Forms.Button();
            this.labelID = new System.Windows.Forms.Label();
            this.idPedidoLabelStatusAtendente = new System.Windows.Forms.Label();
            this.labelEntrgador = new System.Windows.Forms.Label();
            this.comboBoxentregador = new System.Windows.Forms.ComboBox();
            this.grouboxpagamento = new System.Windows.Forms.GroupBox();
            this.groupBoxstatuspedido = new System.Windows.Forms.GroupBox();
            this.grouboxpagamento.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelStatusPagamento
            // 
            this.labelStatusPagamento.AutoSize = true;
            this.labelStatusPagamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusPagamento.Location = new System.Drawing.Point(13, 94);
            this.labelStatusPagamento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusPagamento.Name = "labelStatusPagamento";
            this.labelStatusPagamento.Size = new System.Drawing.Size(204, 25);
            this.labelStatusPagamento.TabIndex = 0;
            this.labelStatusPagamento.Text = "Status do pagamento:";
            // 
            // labelStatusPedido
            // 
            this.labelStatusPedido.AutoSize = true;
            this.labelStatusPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStatusPedido.Location = new System.Drawing.Point(13, 206);
            this.labelStatusPedido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelStatusPedido.Name = "labelStatusPedido";
            this.labelStatusPedido.Size = new System.Drawing.Size(165, 25);
            this.labelStatusPedido.TabIndex = 2;
            this.labelStatusPedido.Text = "Status do pedido:";
            // 
            // pagoRadioBtn
            // 
            this.pagoRadioBtn.AutoSize = true;
            this.pagoRadioBtn.Location = new System.Drawing.Point(7, 27);
            this.pagoRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pagoRadioBtn.Name = "pagoRadioBtn";
            this.pagoRadioBtn.Size = new System.Drawing.Size(71, 24);
            this.pagoRadioBtn.TabIndex = 1;
            this.pagoRadioBtn.TabStop = true;
            this.pagoRadioBtn.Text = "Pago";
            this.pagoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // pendenteRadioBtn
            // 
            this.pendenteRadioBtn.AutoSize = true;
            this.pendenteRadioBtn.Location = new System.Drawing.Point(7, 61);
            this.pendenteRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pendenteRadioBtn.Name = "pendenteRadioBtn";
            this.pendenteRadioBtn.Size = new System.Drawing.Size(103, 24);
            this.pendenteRadioBtn.TabIndex = 2;
            this.pendenteRadioBtn.TabStop = true;
            this.pendenteRadioBtn.Text = "Pendente";
            this.pendenteRadioBtn.UseVisualStyleBackColor = true;
            // 
            // preparoRadioBtn
            // 
            this.preparoRadioBtn.AutoSize = true;
            this.preparoRadioBtn.Location = new System.Drawing.Point(186, 188);
            this.preparoRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.preparoRadioBtn.Name = "preparoRadioBtn";
            this.preparoRadioBtn.Size = new System.Drawing.Size(117, 24);
            this.preparoRadioBtn.TabIndex = 3;
            this.preparoRadioBtn.TabStop = true;
            this.preparoRadioBtn.Text = "Em preparo";
            this.preparoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // RetiradaRadioBtn
            // 
            this.RetiradaRadioBtn.AutoSize = true;
            this.RetiradaRadioBtn.Location = new System.Drawing.Point(186, 222);
            this.RetiradaRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.RetiradaRadioBtn.Name = "RetiradaRadioBtn";
            this.RetiradaRadioBtn.Size = new System.Drawing.Size(95, 24);
            this.RetiradaRadioBtn.TabIndex = 4;
            this.RetiradaRadioBtn.TabStop = true;
            this.RetiradaRadioBtn.Text = "Retirada";
            this.RetiradaRadioBtn.UseVisualStyleBackColor = true;
            // 
            // SaiuRadioBtn
            // 
            this.SaiuRadioBtn.AutoSize = true;
            this.SaiuRadioBtn.Location = new System.Drawing.Point(186, 256);
            this.SaiuRadioBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SaiuRadioBtn.Name = "SaiuRadioBtn";
            this.SaiuRadioBtn.Size = new System.Drawing.Size(161, 24);
            this.SaiuRadioBtn.TabIndex = 5;
            this.SaiuRadioBtn.TabStop = true;
            this.SaiuRadioBtn.Text = "Saiu para entrega";
            this.SaiuRadioBtn.UseVisualStyleBackColor = true;
            this.SaiuRadioBtn.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(276, 374);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(126, 40);
            this.btnFechar.TabIndex = 7;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.button1_Click);
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelID.Location = new System.Drawing.Point(13, 29);
            this.labelID.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(103, 25);
            this.labelID.TabIndex = 9;
            this.labelID.Text = "ID Pedido:";
            // 
            // idPedidoLabelStatusAtendente
            // 
            this.idPedidoLabelStatusAtendente.AutoSize = true;
            this.idPedidoLabelStatusAtendente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idPedidoLabelStatusAtendente.Location = new System.Drawing.Point(124, 29);
            this.idPedidoLabelStatusAtendente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.idPedidoLabelStatusAtendente.Name = "idPedidoLabelStatusAtendente";
            this.idPedidoLabelStatusAtendente.Size = new System.Drawing.Size(100, 25);
            this.idPedidoLabelStatusAtendente.TabIndex = 0;
            this.idPedidoLabelStatusAtendente.Text = "#9901011";
            // 
            // labelEntrgador
            // 
            this.labelEntrgador.AutoSize = true;
            this.labelEntrgador.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntrgador.Location = new System.Drawing.Point(13, 324);
            this.labelEntrgador.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelEntrgador.Name = "labelEntrgador";
            this.labelEntrgador.Size = new System.Drawing.Size(109, 22);
            this.labelEntrgador.TabIndex = 11;
            this.labelEntrgador.Text = "Entregador: ";
            // 
            // comboBoxentregador
            // 
            this.comboBoxentregador.FormattingEnabled = true;
            this.comboBoxentregador.Location = new System.Drawing.Point(123, 323);
            this.comboBoxentregador.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxentregador.Name = "comboBoxentregador";
            this.comboBoxentregador.Size = new System.Drawing.Size(180, 28);
            this.comboBoxentregador.TabIndex = 6;
            // 
            // grouboxpagamento
            // 
            this.grouboxpagamento.Controls.Add(this.pendenteRadioBtn);
            this.grouboxpagamento.Controls.Add(this.pagoRadioBtn);
            this.grouboxpagamento.Location = new System.Drawing.Point(215, 57);
            this.grouboxpagamento.Name = "grouboxpagamento";
            this.grouboxpagamento.Size = new System.Drawing.Size(132, 100);
            this.grouboxpagamento.TabIndex = 12;
            this.grouboxpagamento.TabStop = false;
            this.grouboxpagamento.Text = "pagamento";
            this.grouboxpagamento.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBoxstatuspedido
            // 
            this.groupBoxstatuspedido.Location = new System.Drawing.Point(175, 163);
            this.groupBoxstatuspedido.Name = "groupBoxstatuspedido";
            this.groupBoxstatuspedido.Size = new System.Drawing.Size(210, 128);
            this.groupBoxstatuspedido.TabIndex = 13;
            this.groupBoxstatuspedido.TabStop = false;
            this.groupBoxstatuspedido.Text = "status";
            // 
            // TelaStatusPedidoAtendente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(403, 417);
            this.Controls.Add(this.comboBoxentregador);
            this.Controls.Add(this.labelEntrgador);
            this.Controls.Add(this.idPedidoLabelStatusAtendente);
            this.Controls.Add(this.labelID);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.SaiuRadioBtn);
            this.Controls.Add(this.RetiradaRadioBtn);
            this.Controls.Add(this.preparoRadioBtn);
            this.Controls.Add(this.labelStatusPedido);
            this.Controls.Add(this.labelStatusPagamento);
            this.Controls.Add(this.grouboxpagamento);
            this.Controls.Add(this.groupBoxstatuspedido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaStatusPedidoAtendente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Status Atendente";
            this.grouboxpagamento.ResumeLayout(false);
            this.grouboxpagamento.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelStatusPagamento;
        private System.Windows.Forms.Label labelStatusPedido;
        private System.Windows.Forms.RadioButton pagoRadioBtn;
        private System.Windows.Forms.RadioButton pendenteRadioBtn;
        private System.Windows.Forms.RadioButton preparoRadioBtn;
        private System.Windows.Forms.RadioButton RetiradaRadioBtn;
        private System.Windows.Forms.RadioButton SaiuRadioBtn;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Label idPedidoLabelStatusAtendente;
        private System.Windows.Forms.Label labelEntrgador;
        private System.Windows.Forms.ComboBox comboBoxentregador;
        private System.Windows.Forms.GroupBox grouboxpagamento;
        private System.Windows.Forms.GroupBox groupBoxstatuspedido;
    }
}