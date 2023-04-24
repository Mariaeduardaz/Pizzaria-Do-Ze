namespace Pizzaria_Do_Ze
{
    partial class TelaLogin
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
            this.labelinicio = new System.Windows.Forms.Label();
            this.labelusuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.btnentrar = new System.Windows.Forms.Button();
            this.btnIdioma = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelinicio
            // 
            this.labelinicio.AutoSize = true;
            this.labelinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinicio.Location = new System.Drawing.Point(68, 104);
            this.labelinicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelinicio.Name = "labelinicio";
            this.labelinicio.Size = new System.Drawing.Size(485, 37);
            this.labelinicio.TabIndex = 0;
            this.labelinicio.Text = "Seja Bem-Vindo a pizzaria do Zé";
            this.labelinicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusuario.Location = new System.Drawing.Point(44, 173);
            this.labelusuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelusuario.Name = "labelusuario";
            this.labelusuario.Size = new System.Drawing.Size(102, 29);
            this.labelusuario.TabIndex = 1;
            this.labelusuario.Text = "Usuario:";
            // 
            // labelSenha
            // 
            this.labelSenha.AutoSize = true;
            this.labelSenha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSenha.Location = new System.Drawing.Point(44, 228);
            this.labelSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(88, 29);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha:";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(180, 177);
            this.UserTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(287, 26);
            this.UserTextBox.TabIndex = 3;
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(180, 228);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(287, 26);
            this.senhaTextBox.TabIndex = 4;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(191, 298);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 35);
            this.cancelBtn.TabIndex = 5;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(312, 298);
            this.btnentrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(112, 35);
            this.btnentrar.TabIndex = 6;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // btnIdioma
            // 
            this.btnIdioma.Location = new System.Drawing.Point(12, 12);
            this.btnIdioma.Name = "btnIdioma";
            this.btnIdioma.Size = new System.Drawing.Size(134, 39);
            this.btnIdioma.TabIndex = 7;
            this.btnIdioma.Text = "Idioma";
            this.btnIdioma.UseVisualStyleBackColor = true;
            this.btnIdioma.Click += new System.EventHandler(this.btnIdioma_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(574, 373);
            this.Controls.Add(this.btnIdioma);
            this.Controls.Add(this.btnentrar);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.senhaTextBox);
            this.Controls.Add(this.UserTextBox);
            this.Controls.Add(this.labelSenha);
            this.Controls.Add(this.labelusuario);
            this.Controls.Add(this.labelinicio);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label labelinicio;
        private System.Windows.Forms.Label labelusuario;
        private System.Windows.Forms.Label labelSenha;
        private System.Windows.Forms.TextBox UserTextBox;
        private System.Windows.Forms.TextBox senhaTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button btnentrar;
        private System.Windows.Forms.Button btnIdioma;
    }
}

