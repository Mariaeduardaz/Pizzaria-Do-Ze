namespace Pizzaria_Do_Ze
{
    partial class Telaprincipal
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
            this.btnAdministrador = new System.Windows.Forms.Button();
            this.btnPizza = new System.Windows.Forms.Button();
            this.btnEntregador = new System.Windows.Forms.Button();
            this.btnAtendente = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAdministrador
            // 
            this.btnAdministrador.Location = new System.Drawing.Point(12, 88);
            this.btnAdministrador.Name = "btnAdministrador";
            this.btnAdministrador.Size = new System.Drawing.Size(124, 44);
            this.btnAdministrador.TabIndex = 0;
            this.btnAdministrador.Text = "Administrador";
            this.btnAdministrador.UseVisualStyleBackColor = true;
            this.btnAdministrador.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPizza
            // 
            this.btnPizza.Location = new System.Drawing.Point(394, 88);
            this.btnPizza.Name = "btnPizza";
            this.btnPizza.Size = new System.Drawing.Size(130, 44);
            this.btnPizza.TabIndex = 3;
            this.btnPizza.Text = "Pizza";
            this.btnPizza.UseVisualStyleBackColor = true;
            this.btnPizza.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEntregador
            // 
            this.btnEntregador.Location = new System.Drawing.Point(268, 88);
            this.btnEntregador.Name = "btnEntregador";
            this.btnEntregador.Size = new System.Drawing.Size(120, 44);
            this.btnEntregador.TabIndex = 2;
            this.btnEntregador.Text = "Entregador";
            this.btnEntregador.UseVisualStyleBackColor = true;
            this.btnEntregador.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnAtendente
            // 
            this.btnAtendente.Location = new System.Drawing.Point(142, 88);
            this.btnAtendente.Name = "btnAtendente";
            this.btnAtendente.Size = new System.Drawing.Size(120, 44);
            this.btnAtendente.TabIndex = 1;
            this.btnAtendente.Text = "Atendente";
            this.btnAtendente.UseVisualStyleBackColor = true;
            this.btnAtendente.Click += new System.EventHandler(this.button4_Click);
            // 
            // Telaprincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(536, 196);
            this.Controls.Add(this.btnAtendente);
            this.Controls.Add(this.btnEntregador);
            this.Controls.Add(this.btnPizza);
            this.Controls.Add(this.btnAdministrador);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Telaprincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Telaprincipal";
            this.Load += new System.EventHandler(this.Telaprincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAdministrador;
        private System.Windows.Forms.Button btnPizza;
        private System.Windows.Forms.Button btnEntregador;
        private System.Windows.Forms.Button btnAtendente;
    }
}