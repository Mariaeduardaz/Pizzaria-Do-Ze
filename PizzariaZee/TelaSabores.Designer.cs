namespace PizzariaZee
{
    partial class TelaSabores
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
            this.saboresListBox = new System.Windows.Forms.ListBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.excluirBtn = new System.Windows.Forms.Button();
            this.voltarBtn = new System.Windows.Forms.Button();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // saboresListBox
            // 
            this.saboresListBox.FormattingEnabled = true;
            this.saboresListBox.ItemHeight = 20;
            this.saboresListBox.Location = new System.Drawing.Point(13, 75);
            this.saboresListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.saboresListBox.Name = "saboresListBox";
            this.saboresListBox.Size = new System.Drawing.Size(414, 304);
            this.saboresListBox.TabIndex = 4;
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(13, 14);
            this.addBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(92, 51);
            this.addBtn.TabIndex = 0;
            this.addBtn.Text = "Adicionar";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(112, 14);
            this.editBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(95, 51);
            this.editBtn.TabIndex = 1;
            this.editBtn.Text = "Editar";
            this.editBtn.UseVisualStyleBackColor = true;
            // 
            // excluirBtn
            // 
            this.excluirBtn.Location = new System.Drawing.Point(325, 14);
            this.excluirBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.excluirBtn.Name = "excluirBtn";
            this.excluirBtn.Size = new System.Drawing.Size(102, 51);
            this.excluirBtn.TabIndex = 3;
            this.excluirBtn.Text = "Excluir";
            this.excluirBtn.UseVisualStyleBackColor = true;
            // 
            // voltarBtn
            // 
            this.voltarBtn.Location = new System.Drawing.Point(379, 389);
            this.voltarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.voltarBtn.Name = "voltarBtn";
            this.voltarBtn.Size = new System.Drawing.Size(122, 51);
            this.voltarBtn.TabIndex = 5;
            this.voltarBtn.Text = "Voltar";
            this.voltarBtn.UseVisualStyleBackColor = true;
            this.voltarBtn.Click += new System.EventHandler(this.voltarBtn_Click);
            // 
            // btnVerificar
            // 
            this.btnVerificar.Location = new System.Drawing.Point(215, 14);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(102, 51);
            this.btnVerificar.TabIndex = 2;
            this.btnVerificar.Text = "Verificar";
            this.btnVerificar.UseVisualStyleBackColor = true;
            // 
            // TelaSabores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(509, 443);
            this.Controls.Add(this.btnVerificar);
            this.Controls.Add(this.voltarBtn);
            this.Controls.Add(this.excluirBtn);
            this.Controls.Add(this.editBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.saboresListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaSabores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tela Sabor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox saboresListBox;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button excluirBtn;
        private System.Windows.Forms.Button voltarBtn;
        private System.Windows.Forms.Button btnVerificar;
    }
}