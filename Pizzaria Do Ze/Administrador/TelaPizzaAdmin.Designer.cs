namespace Pizzaria_Do_Ze.Telas_Cadastrais
{
    partial class TelaPizzaAdmin
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
            this.saboresBtn = new System.Windows.Forms.Button();
            this.valoresBtn = new System.Windows.Forms.Button();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnIngrendiente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saboresBtn
            // 
            this.saboresBtn.Location = new System.Drawing.Point(48, 127);
            this.saboresBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saboresBtn.Name = "saboresBtn";
            this.saboresBtn.Size = new System.Drawing.Size(213, 68);
            this.saboresBtn.TabIndex = 0;
            this.saboresBtn.Text = "Sabor";
            this.saboresBtn.UseVisualStyleBackColor = true;
            this.saboresBtn.Click += new System.EventHandler(this.saboresBtn_Click);
            // 
            // valoresBtn
            // 
            this.valoresBtn.Location = new System.Drawing.Point(48, 49);
            this.valoresBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.valoresBtn.Name = "valoresBtn";
            this.valoresBtn.Size = new System.Drawing.Size(213, 68);
            this.valoresBtn.TabIndex = 1;
            this.valoresBtn.Text = "Valores pizza";
            this.valoresBtn.UseVisualStyleBackColor = true;
            this.valoresBtn.Click += new System.EventHandler(this.valoresBtn_Click);
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(223, 283);
            this.btnVoltar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(106, 30);
            this.btnVoltar.TabIndex = 2;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnIngrendiente
            // 
            this.btnIngrendiente.Location = new System.Drawing.Point(48, 205);
            this.btnIngrendiente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnIngrendiente.Name = "btnIngrendiente";
            this.btnIngrendiente.Size = new System.Drawing.Size(213, 68);
            this.btnIngrendiente.TabIndex = 4;
            this.btnIngrendiente.Text = "Ingrediente";
            this.btnIngrendiente.UseVisualStyleBackColor = true;
            this.btnIngrendiente.Click += new System.EventHandler(this.button2_Click);
            // 
            // TelaPizzaAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(333, 321);
            this.Controls.Add(this.btnIngrendiente);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.valoresBtn);
            this.Controls.Add(this.saboresBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaPizzaAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administrador";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saboresBtn;
        private System.Windows.Forms.Button valoresBtn;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.Button btnIngrendiente;
    }
}