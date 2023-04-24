using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pizzaria_Do_Ze.Administrador
{
    /// <summary>
    /// Tela para os cadastros em geral
    /// </summary>
    public partial class CadGenerico : UserControl
    {
        public CadGenerico()
        {
            InitializeComponent();
            nameTextBot.Focus();
        }

        

        private void CPFMaskedTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void CEPMaskedTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void labelEndereco_Click(object sender, EventArgs e)
        {

        }

        private void labelCEP_Click(object sender, EventArgs e)
        {

        }

        private void labelCPF_Click(object sender, EventArgs e)
        {

        }

        private void labelEmail_Click(object sender, EventArgs e)
        {

        }

        private void labelTelefone_Click(object sender, EventArgs e)
        {

        }

        private void labelNome_Click(object sender, EventArgs e)
        {

        }

        private void complementoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enderecoTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void TelefoneMaskTB_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void nameTextBot_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
