namespace Pizzaria_Do_Ze
{
    partial class TelaDeSair
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
            this.labelsairaplicacao = new System.Windows.Forms.Label();
            this.btnJogarBandeja = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelsairaplicacao
            // 
            this.labelsairaplicacao.AutoSize = true;
            this.labelsairaplicacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelsairaplicacao.Location = new System.Drawing.Point(12, 55);
            this.labelsairaplicacao.Name = "labelsairaplicacao";
            this.labelsairaplicacao.Size = new System.Drawing.Size(240, 20);
            this.labelsairaplicacao.TabIndex = 0;
            this.labelsairaplicacao.Text = "Deseja sair desta aplicação?";
            // 
            // btnJogarBandeja
            // 
            this.btnJogarBandeja.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.btnJogarBandeja.Location = new System.Drawing.Point(283, 50);
            this.btnJogarBandeja.Name = "btnJogarBandeja";
            this.btnJogarBandeja.Size = new System.Drawing.Size(186, 31);
            this.btnJogarBandeja.TabIndex = 1;
            this.btnJogarBandeja.Text = "Jogar para bandeja ";
            this.btnJogarBandeja.UseVisualStyleBackColor = true;
            // 
            // cancelBtn
            // 
            this.cancelBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelBtn.Location = new System.Drawing.Point(378, 118);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(91, 36);
            this.cancelBtn.TabIndex = 2;
            this.cancelBtn.Text = "Cancelar";
            this.cancelBtn.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSair.Location = new System.Drawing.Point(273, 118);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(99, 36);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // TelaDeSair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(481, 166);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.btnJogarBandeja);
            this.Controls.Add(this.labelsairaplicacao);
            this.Name = "TelaDeSair";
            this.Text = "TelaDeSair";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelsairaplicacao;
        private System.Windows.Forms.Button btnJogarBandeja;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button btnSair;
    }
}