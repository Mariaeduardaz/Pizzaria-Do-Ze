namespace PizzariadoZe.Telas_Admin
{
    partial class CadBordas
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
            this.BtnAddBorda = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.bordaListBox = new System.Windows.Forms.ListBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnAddBorda
            // 
            this.BtnAddBorda.Location = new System.Drawing.Point(18, 46);
            this.BtnAddBorda.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnAddBorda.Name = "BtnAddBorda";
            this.BtnAddBorda.Size = new System.Drawing.Size(142, 51);
            this.BtnAddBorda.TabIndex = 0;
            this.BtnAddBorda.Text = "Adicionar";
            this.BtnAddBorda.UseVisualStyleBackColor = true;
            this.BtnAddBorda.Click += new System.EventHandler(this.addBordaBtn_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(180, 46);
            this.BtnExcluir.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(183, 51);
            this.BtnExcluir.TabIndex = 1;
            this.BtnExcluir.Text = "Excluir selecionado";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            // 
            // bordaListBox
            // 
            this.bordaListBox.FormattingEnabled = true;
            this.bordaListBox.ItemHeight = 20;
            this.bordaListBox.Location = new System.Drawing.Point(18, 122);
            this.bordaListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bordaListBox.Name = "bordaListBox";
            this.bordaListBox.Size = new System.Drawing.Size(343, 204);
            this.bordaListBox.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(369, 297);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(142, 51);
            this.btnCancelar.TabIndex = 4;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // CadBordas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(517, 360);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.bordaListBox);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.BtnAddBorda);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CadBordas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadBordas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddBorda;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.ListBox bordaListBox;
        private System.Windows.Forms.Button btnCancelar;
    }
}