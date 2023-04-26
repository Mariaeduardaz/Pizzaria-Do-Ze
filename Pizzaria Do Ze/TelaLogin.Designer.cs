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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaLogin));
            this.labelinicio = new System.Windows.Forms.Label();
            this.labelusuario = new System.Windows.Forms.Label();
            this.labelSenha = new System.Windows.Forms.Label();
            this.UserTextBox = new System.Windows.Forms.TextBox();
            this.senhaTextBox = new System.Windows.Forms.TextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.btnentrar = new System.Windows.Forms.Button();
            this.btnIdioma = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.abrirAplicaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.encerrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sobreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelinicio
            // 
            this.labelinicio.AutoSize = true;
            this.labelinicio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.labelinicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelinicio.ForeColor = System.Drawing.Color.Red;
            this.labelinicio.Location = new System.Drawing.Point(209, 24);
            this.labelinicio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelinicio.Name = "labelinicio";
            this.labelinicio.Size = new System.Drawing.Size(274, 74);
            this.labelinicio.TabIndex = 1;
            this.labelinicio.Text = "Seja Bem-Vindo a\r\n pizzaria do Zé";
            this.labelinicio.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelinicio.Click += new System.EventHandler(this.labelinicio_Click);
            // 
            // labelusuario
            // 
            this.labelusuario.AutoSize = true;
            this.labelusuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelusuario.Location = new System.Drawing.Point(186, 125);
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
            this.labelSenha.Location = new System.Drawing.Point(186, 173);
            this.labelSenha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelSenha.Name = "labelSenha";
            this.labelSenha.Size = new System.Drawing.Size(88, 29);
            this.labelSenha.TabIndex = 2;
            this.labelSenha.Text = "Senha:";
            // 
            // UserTextBox
            // 
            this.UserTextBox.Location = new System.Drawing.Point(312, 125);
            this.UserTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.UserTextBox.Name = "UserTextBox";
            this.UserTextBox.Size = new System.Drawing.Size(287, 26);
            this.UserTextBox.TabIndex = 2;
            this.UserTextBox.TextChanged += new System.EventHandler(this.UserTextBox_TextChanged);
            // 
            // senhaTextBox
            // 
            this.senhaTextBox.Location = new System.Drawing.Point(312, 173);
            this.senhaTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.senhaTextBox.Name = "senhaTextBox";
            this.senhaTextBox.Size = new System.Drawing.Size(287, 26);
            this.senhaTextBox.TabIndex = 3;
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(312, 234);
            this.cancelBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(112, 35);
            this.cancelBtn.TabIndex = 4;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // btnentrar
            // 
            this.btnentrar.Location = new System.Drawing.Point(457, 234);
            this.btnentrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnentrar.Name = "btnentrar";
            this.btnentrar.Size = new System.Drawing.Size(112, 35);
            this.btnentrar.TabIndex = 5;
            this.btnentrar.Text = "Entrar";
            this.btnentrar.UseVisualStyleBackColor = true;
            this.btnentrar.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // btnIdioma
            // 
            this.btnIdioma.Location = new System.Drawing.Point(12, 12);
            this.btnIdioma.Name = "btnIdioma";
            this.btnIdioma.Size = new System.Drawing.Size(92, 33);
            this.btnIdioma.TabIndex = 0;
            this.btnIdioma.Text = "Idioma";
            this.btnIdioma.UseVisualStyleBackColor = true;
            this.btnIdioma.Click += new System.EventHandler(this.btnIdioma_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirAplicaçãoToolStripMenuItem,
            this.encerrarToolStripMenuItem,
            this.sobreToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(202, 100);
            // 
            // abrirAplicaçãoToolStripMenuItem
            // 
            this.abrirAplicaçãoToolStripMenuItem.Name = "abrirAplicaçãoToolStripMenuItem";
            this.abrirAplicaçãoToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.abrirAplicaçãoToolStripMenuItem.Text = "Abrir aplicação";
            // 
            // encerrarToolStripMenuItem
            // 
            this.encerrarToolStripMenuItem.Name = "encerrarToolStripMenuItem";
            this.encerrarToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.encerrarToolStripMenuItem.Text = "Encerrar";
            // 
            // sobreToolStripMenuItem
            // 
            this.sobreToolStripMenuItem.Name = "sobreToolStripMenuItem";
            this.sobreToolStripMenuItem.Size = new System.Drawing.Size(201, 32);
            this.sobreToolStripMenuItem.Text = "Sobre";
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Aplicacao continua executando na bandeja";
            this.notifyIcon1.BalloonTipTitle = "Pizzaria do zé";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Text = "notifyIconSystemTray";
            this.notifyIcon1.Visible = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(22, 64);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(127, 233);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(619, 333);
            this.Controls.Add(this.pictureBox1);
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
            this.Load += new System.EventHandler(this.TelaLogin_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem abrirAplicaçãoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem encerrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sobreToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

