namespace Pizzaria_Do_Ze.Telas_Pedido
{
    partial class TelaRetirarIngrediente
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
            this.labelIngrendiente = new System.Windows.Forms.Label();
            this.comboBoxIngrediente = new System.Windows.Forms.ComboBox();
            this.ingredientesListBox = new System.Windows.Forms.ListBox();
            this.retirarBtn = new System.Windows.Forms.Button();
            this.cancelbtn = new System.Windows.Forms.Button();
            this.ConcluirBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelIngrendiente
            // 
            this.labelIngrendiente.AutoSize = true;
            this.labelIngrendiente.Location = new System.Drawing.Point(13, 28);
            this.labelIngrendiente.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelIngrendiente.Name = "labelIngrendiente";
            this.labelIngrendiente.Size = new System.Drawing.Size(94, 20);
            this.labelIngrendiente.TabIndex = 0;
            this.labelIngrendiente.Text = "Ingrediente:";
            // 
            // comboBoxIngrediente
            // 
            this.comboBoxIngrediente.FormattingEnabled = true;
            this.comboBoxIngrediente.Location = new System.Drawing.Point(123, 25);
            this.comboBoxIngrediente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBoxIngrediente.Name = "comboBoxIngrediente";
            this.comboBoxIngrediente.Size = new System.Drawing.Size(248, 28);
            this.comboBoxIngrediente.TabIndex = 0;
            // 
            // ingredientesListBox
            // 
            this.ingredientesListBox.FormattingEnabled = true;
            this.ingredientesListBox.ItemHeight = 20;
            this.ingredientesListBox.Location = new System.Drawing.Point(17, 66);
            this.ingredientesListBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ingredientesListBox.Name = "ingredientesListBox";
            this.ingredientesListBox.Size = new System.Drawing.Size(441, 224);
            this.ingredientesListBox.TabIndex = 1;
            // 
            // retirarBtn
            // 
            this.retirarBtn.Location = new System.Drawing.Point(287, 255);
            this.retirarBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.retirarBtn.Name = "retirarBtn";
            this.retirarBtn.Size = new System.Drawing.Size(171, 35);
            this.retirarBtn.TabIndex = 2;
            this.retirarBtn.Text = "Retirar Selecionado";
            this.retirarBtn.UseVisualStyleBackColor = true;
            // 
            // cancelbtn
            // 
            this.cancelbtn.Location = new System.Drawing.Point(345, 327);
            this.cancelbtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelbtn.Name = "cancelbtn";
            this.cancelbtn.Size = new System.Drawing.Size(113, 33);
            this.cancelbtn.TabIndex = 3;
            this.cancelbtn.Text = "Cancelar";
            this.cancelbtn.UseVisualStyleBackColor = true;
            this.cancelbtn.Click += new System.EventHandler(this.cancelbtn_Click);
            // 
            // ConcluirBtn
            // 
            this.ConcluirBtn.Location = new System.Drawing.Point(462, 327);
            this.ConcluirBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ConcluirBtn.Name = "ConcluirBtn";
            this.ConcluirBtn.Size = new System.Drawing.Size(108, 33);
            this.ConcluirBtn.TabIndex = 4;
            this.ConcluirBtn.Text = "Concluir";
            this.ConcluirBtn.UseVisualStyleBackColor = true;
            this.ConcluirBtn.Click += new System.EventHandler(this.ConcluirBtn_Click);
            // 
            // TelaRetirarIngrediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(583, 364);
            this.Controls.Add(this.ConcluirBtn);
            this.Controls.Add(this.cancelbtn);
            this.Controls.Add(this.retirarBtn);
            this.Controls.Add(this.ingredientesListBox);
            this.Controls.Add(this.comboBoxIngrediente);
            this.Controls.Add(this.labelIngrendiente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TelaRetirarIngrediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TelaRetirarIngrediente";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelIngrendiente;
        private System.Windows.Forms.ComboBox comboBoxIngrediente;
        private System.Windows.Forms.ListBox ingredientesListBox;
        private System.Windows.Forms.Button retirarBtn;
        private System.Windows.Forms.Button cancelbtn;
        private System.Windows.Forms.Button ConcluirBtn;
    }
}