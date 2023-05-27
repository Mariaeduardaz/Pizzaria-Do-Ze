namespace PizzariadoZe
{
    partial class UserControlOperacoes
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btneditar = new System.Windows.Forms.Button();
            this.btnadicionar = new System.Windows.Forms.Button();
            this.btnexcluir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btneditar
            // 
            this.btneditar.Location = new System.Drawing.Point(14, 50);
            this.btneditar.Name = "btneditar";
            this.btneditar.Size = new System.Drawing.Size(95, 43);
            this.btneditar.TabIndex = 0;
            this.btneditar.Text = "editar";
            this.btneditar.UseVisualStyleBackColor = true;
            // 
            // btnadicionar
            // 
            this.btnadicionar.Location = new System.Drawing.Point(127, 50);
            this.btnadicionar.Name = "btnadicionar";
            this.btnadicionar.Size = new System.Drawing.Size(95, 43);
            this.btnadicionar.TabIndex = 1;
            this.btnadicionar.Text = "adicionar";
            this.btnadicionar.UseVisualStyleBackColor = true;
            // 
            // btnexcluir
            // 
            this.btnexcluir.Location = new System.Drawing.Point(239, 50);
            this.btnexcluir.Name = "btnexcluir";
            this.btnexcluir.Size = new System.Drawing.Size(95, 43);
            this.btnexcluir.TabIndex = 2;
            this.btnexcluir.Text = "excluir";
            this.btnexcluir.UseVisualStyleBackColor = true;
            // 
            // UserControlOperacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.btnexcluir);
            this.Controls.Add(this.btnadicionar);
            this.Controls.Add(this.btneditar);
            this.Name = "UserControlOperacoes";
            this.Size = new System.Drawing.Size(361, 127);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btneditar;
        private System.Windows.Forms.Button btnadicionar;
        private System.Windows.Forms.Button btnexcluir;
    }
}
