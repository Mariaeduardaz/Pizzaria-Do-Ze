namespace Pizzaria_Do_Ze
{
    partial class TelaDeConfg
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
            this.comboBoxIdioma = new System.Windows.Forms.ComboBox();
            this.LabelIdioma = new System.Windows.Forms.Label();
            this.checkBoxIdiomaReiniciar = new System.Windows.Forms.CheckBox();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.LabelConfiguracoes = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxIdioma
            // 
            this.comboBoxIdioma.FormattingEnabled = true;
            this.comboBoxIdioma.Items.AddRange(new object[] {
            "pt-BR",
            "es",
            "en-US"});
            this.comboBoxIdioma.Location = new System.Drawing.Point(17, 99);
            this.comboBoxIdioma.Name = "comboBoxIdioma";
            this.comboBoxIdioma.Size = new System.Drawing.Size(132, 28);
            this.comboBoxIdioma.TabIndex = 0;
            // 
            // LabelIdioma
            // 
            this.LabelIdioma.AutoSize = true;
            this.LabelIdioma.Location = new System.Drawing.Point(13, 65);
            this.LabelIdioma.Name = "LabelIdioma";
            this.LabelIdioma.Size = new System.Drawing.Size(112, 20);
            this.LabelIdioma.TabIndex = 1;
            this.LabelIdioma.Text = "Idioma/Região";
            // 
            // checkBoxIdiomaReiniciar
            // 
            this.checkBoxIdiomaReiniciar.AutoSize = true;
            this.checkBoxIdiomaReiniciar.Location = new System.Drawing.Point(155, 103);
            this.checkBoxIdiomaReiniciar.Name = "checkBoxIdiomaReiniciar";
            this.checkBoxIdiomaReiniciar.Size = new System.Drawing.Size(392, 24);
            this.checkBoxIdiomaReiniciar.TabIndex = 1;
            this.checkBoxIdiomaReiniciar.Text = "Reiniciar para aplicar o novo idioma imediatamente";
            this.checkBoxIdiomaReiniciar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(428, 156);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(119, 39);
            this.BtnSalvar.TabIndex = 2;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // LabelConfiguracoes
            // 
            this.LabelConfiguracoes.AutoSize = true;
            this.LabelConfiguracoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelConfiguracoes.Location = new System.Drawing.Point(12, 9);
            this.LabelConfiguracoes.Name = "LabelConfiguracoes";
            this.LabelConfiguracoes.Size = new System.Drawing.Size(152, 26);
            this.LabelConfiguracoes.TabIndex = 4;
            this.LabelConfiguracoes.Text = "Configurações";
            // 
            // TelaDeConfg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(560, 207);
            this.Controls.Add(this.LabelConfiguracoes);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.checkBoxIdiomaReiniciar);
            this.Controls.Add(this.LabelIdioma);
            this.Controls.Add(this.comboBoxIdioma);
            this.Name = "TelaDeConfg";
            this.Text = "TelaDeConfg";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxIdioma;
        private System.Windows.Forms.Label LabelIdioma;
        private System.Windows.Forms.CheckBox checkBoxIdiomaReiniciar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Label LabelConfiguracoes;
    }
}