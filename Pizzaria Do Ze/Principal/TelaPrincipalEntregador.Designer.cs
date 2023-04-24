namespace Pizzaria_Do_Ze
{
    partial class TelaPrincipalEntregador
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
            this.pedPendentesBtn = new System.Windows.Forms.Button();
            this.pedEntreguesBtn = new System.Windows.Forms.Button();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pedPendentesBtn
            // 
            this.pedPendentesBtn.Location = new System.Drawing.Point(53, 98);
            this.pedPendentesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pedPendentesBtn.Name = "pedPendentesBtn";
            this.pedPendentesBtn.Size = new System.Drawing.Size(221, 52);
            this.pedPendentesBtn.TabIndex = 0;
            this.pedPendentesBtn.Text = " Pedidos Pendentes";
            this.pedPendentesBtn.UseVisualStyleBackColor = true;
            this.pedPendentesBtn.Click += new System.EventHandler(this.pedPendentesBtn_Click);
            // 
            // pedEntreguesBtn
            // 
            this.pedEntreguesBtn.Location = new System.Drawing.Point(53, 36);
            this.pedEntreguesBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pedEntreguesBtn.Name = "pedEntreguesBtn";
            this.pedEntreguesBtn.Size = new System.Drawing.Size(221, 52);
            this.pedEntreguesBtn.TabIndex = 1;
            this.pedEntreguesBtn.Text = " Pedidos Entregues";
            this.pedEntreguesBtn.UseVisualStyleBackColor = true;
            this.pedEntreguesBtn.Click += new System.EventHandler(this.pedEntreguesBtn_Click);
            // 
            // voltarBtn
            // 
            this.voltarBtn.Location = new System.Drawing.Point(238, 182);
            this.voltarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(112, 35);
            this.voltarBtn.TabIndex = 2;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // TelaPrincipalEntregador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(356, 223);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.pedEntreguesBtn);
            this.Controls.Add(this.pedPendentesBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPrincipalEntregador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal Entregador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pedPendentesBtn;
        private System.Windows.Forms.Button pedEntreguesBtn;
        private System.Windows.Forms.Button voltarBtn;
    }
}